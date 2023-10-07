#include <iostream>
#include <string>
#include <vector>
#include <fstream>
#include <typeinfo>
#include <array>
#include <cmath>

using namespace std;

class Point {
private:
    string name;
    float x;
    float y;

public:
    Point(float x = 0, float y = 0, string name="default") {
        this->x = x;
        this->y = y;
        this->name = name;
    }

    string toString() { return "Name: " + name + "\nX: " + to_string(x) + "\nY: " + to_string(y); }
    float X() { return x; }
    float Y() { return y; }
    string Name() { return name; }
};

class Vector{
private:
    Point a;
    Point b;
public:
    Vector(float x1, float y1, string name1, float x2, float y2, string name2) {
        this->a = Point(x1, y1, name1);
        this->b = Point(x2, y2, name2);
    }

    Vector(Point a, Point b) {
        this->a = a;
        this->b = b;
    }

    Point PointA() { return a; }
    Point PointB() { return b; }

    float get_x() { return this->b.X() - this->a.X(); }
    float get_y() { return this->b.Y() - this->a.Y(); }

    float get_length() {
        return sqrt(get_x() * get_x() + get_y() * get_y());
    }

    float get_angle(Vector a) {
        return (float)acos((this->get_x() * a.get_x() + this->get_y() * a.get_y()) / (this->get_length() * a.get_length()) );
    }
};

class FileData{
private:
    vector<string> p;
public:
    FileData(string filename) {
        ifstream file( filename );

        if ( !file.is_open() ) {
            throw std::runtime_error( "File doesn't exist." );
        }

        vector<string> file_data;
        while ( !file.eof() )
        {
            string line_from_file;
            getline( file, line_from_file, '\n' );

            if ( !line_from_file.empty() )
                file_data.push_back( line_from_file );
        }

        file.close();
        this->p = file_data;
    }

    vector<string> return_data() { return p; }
};

class Points{
private:
    vector<Point> points_list;
public:
    Points(string filename){
        FileData *data = new FileData(filename);

        for (string s : data->return_data()) {
            size_t pos1 = s.find(':');
            double x = stod((s.substr(pos1 + 2, s.find(',', pos1) - pos1 - 2)).c_str());

            string name = s.substr(0, pos1);

            size_t pos2 = s.find(',');
            double y = stod((s.substr(pos2 + 2, s.length())).c_str());

            points_list.push_back(Point((float)x, (float)y, name));
        }

        delete data;
    }

    vector<Point> *get_points() { return &points_list; }
};

void print_path(string filename, float x1, float y1, float x2, float y2) {
    Points tmp = Points(filename);
    vector<Point> *p_list = tmp.get_points();
    Point start;
    Point dest;
    float prec = 0.01;
    vector<Point> points_list;

    for (Point p : *p_list) {
        if (abs(p.X() - x1) < prec && abs(p.Y() - y1) < prec) {
            start = p;
        }
        else if (abs(p.X() - x2) < prec && abs(p.Y() - y2 )< prec) {
            dest = p;
        }
        else {
            points_list.push_back(p);
        }
    }

    Vector basis = Vector(start, dest);
    vector<Vector> vectors;
    cout << "============================================\n\nPath:\n\n";
    cout << "Start:\n" << start.toString() << "\n\nDestination:\n" << dest.toString();

    for (Point p : *p_list) {
        if ( !(abs(p.X() - start.X()) < 0.01 && abs(p.Y() - start.Y()) < 0.01) &&
             !(abs(p.X() - dest.X()) < 0.01 && abs(p.Y() - dest.Y()) < 0.01)) {
            Vector v(start, p);
            vectors.push_back(v);
        }
    }

    cout << "\n\nPath would also contain next points:\n\n";
    for (Vector v : vectors) {
        if (basis.get_angle(v) < 3.14 / 100) {
            cout << v.PointB().toString() << "\n\n";
        }
    }

    cout << "============================================n";
}

int main()
{
    print_path("test.txt", -4, 1, 4, 5);
}
