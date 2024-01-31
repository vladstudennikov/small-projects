#include <iostream>
#include <string>
#include <algorithm>
#include <queue>
#include <vector>
#include <cstring>

using namespace std;

class Maze{
    int** maze;
    int len;

    int get_maze_size(const string& maze) { return maze.substr(0, maze.find('\n')).length(); }

    void parse_maze(const string& s) {
        int c = 0;
        int bias = 0;
        for (int i = 0; i < this->len; ++i) {
            for (int j = 0; j < this->len; ++j) {
                maze[i][j] = (s[c + bias] == '.') ? 0 : 1;
                ++c;
            }
            ++bias;
        }
    }

    class CoordinateValidator{
    public:
        bool operator()(pair<int, int> p, int** distances, int len, int** maze) {
            if (p.first < 0 || p.first > len - 1) return false;
            if (p.second < 0 || p.second > len - 1) return false;
            if (distances[p.first][p.second] != -1) return false;
            if (maze[p.first][p.second] == 1) return false;

            return true;
        }
    };

    void delete_2d_array(int** arr, int len) {
        for(int i = 0; i < len; ++i)
            delete [] arr[i];
        delete [] arr;
    }

    int** init_2d_array(int l, int filling) {
        int** arr = new int*[len];
        for (int i = 0; i < len; ++i) {
            arr[i] = new int[len];
            memset(arr[i], filling, len * sizeof(int));
        }
        return arr;
    }

public:
    Maze(const string& s) {
        len = this->get_maze_size(s);
        this->maze = init_2d_array(len, 0);
        this->parse_maze(s);
    }

    ~Maze() { delete_2d_array(this->maze, this->len); }

    int get_distance() {
        queue<pair<int, int>> q;
        q.push(make_pair(0, 0));

        int** distances = init_2d_array(len, -1);
        while (q.size() != 0) {
            pair<int, int> el = q.front();
            q.pop();
            if (el.first == len - 1 && el.second == len - 1) {
                int value = distances[len - 1][len - 1] + 1;
                delete_2d_array(distances, len);
                return value;
            }

            vector<pair<int, int>> possible_positions;
            Maze::CoordinateValidator validate;

            for (int i : {-1, 1}) {
                pair<int, int> coords1 = make_pair(el.first + i, el.second);
                pair<int, int> coords2 = make_pair(el.first, el.second + i);
                if (validate(coords1, distances, len, maze)) possible_positions.push_back(coords1);
                if (validate(coords2, distances, len, maze)) possible_positions.push_back(coords2);
            }

            for (pair<int, int> i : possible_positions) {
                q.push(i);
                distances[i.first][i.second] = distances[el.first][el.second] + 1;
            }
        }

        delete_2d_array(distances, len);
        return -1;
    }

    int** get_maze() { return this->maze; }
    int get_size() { return this->len; }
};

int main()
{
    Maze a("......\n......\n......\n......\n......\n......");
    cout << a.get_distance();
}
