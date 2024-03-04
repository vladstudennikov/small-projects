#include <iostream>
#include <string>
#include <algorithm>
#include <queue>
#include <vector>
#include <cstring>
#include <cmath>
#include <limits.h>

using namespace std;

class Cell{
private:
    int x;
    int y;
public:
    Cell(int x1, int y1) : x(x1), y(y1) {}
    int X(){ return x; }
    int Y(){ return y; }
};

class PriorityQueue{
private:
    vector<Cell> q;
    vector<vector<int>>& distances;
public:
    PriorityQueue(vector<vector<int>>& dist) : distances(dist) {}

    vector<Cell> get_new_positions(Cell& curr, int len) {
        vector<Cell> pos;
        for (int i : {-1, 1}) {
            if (curr.X() + i >= 0 && curr.X() + i < len) {
                Cell tmp(curr.X() + i, curr.Y());
                pos.push_back(tmp);
            }
            if (curr.Y() + i >= 0 && curr.Y() + i < len) {
                Cell tmp(curr.X(), curr.Y() + i);
                pos.push_back(tmp);
            }
        }
        return pos;
    }

    void add(Cell x) {
        for (int i = 0; i < q.size(); ++i) {
            if (q[i].X() == x.X() && q[i].Y() == x.Y()) { return; }
        }
        q.push_back(x);
    }

    Cell pop(vector<vector<bool>>& visited, vector<vector<int>>& m) {
        int d = INT_MAX;
        int idx = -1;
        Cell res(-1,-1);
        Cell neighbour(-1,-1);
        int c = 0;

        for (Cell i : q) {
            for (Cell j : this->get_new_positions(i, m.size())) {
                if (visited[j.X()][j.Y()] && distances[j.X()][j.Y()] + abs(m[j.X()][j.Y()] - m[i.X()][i.Y()]) < d) {
                    res = i;
                    neighbour = j;
                    idx = c;
                    d = distances[j.X()][j.Y()] + abs(m[j.X()][j.Y()] - m[i.X()][i.Y()]);
                }

            }
            ++c;
        }

        if (idx == -1) { return res; }

        q.erase(q.begin() + idx);
        visited[res.X()][res.Y()] = true;
        distances[res.X()][res.Y()] = distances[neighbour.X()][neighbour.Y()] + abs(m[res.X()][res.Y()] - m[neighbour.X()][neighbour.Y()]);
        return res;
    }

    vector<Cell> get_queue() { return q; }
};

class Maze{
    int len;
    vector<vector<int>> maze;

    int get_maze_size(const string& maze) { return maze.substr(0, maze.find('\n')).length(); }

    void parse_maze(const string& s) {
        int c = 0;
        int bias = 0;
        for (int i = 0; i < this->len; ++i) {
            for (int j = 0; j < this->len; ++j) {
                maze[i][j] = static_cast<int>(s[c + bias]) - '0';
                ++c;
            }
            ++bias;
        }
    }

    vector<Cell> get_new_positions(Cell& curr) {
        vector<Cell> pos;
        for (int i : {-1, 1}) {
            if (curr.X() + i >= 0 && curr.X() + i < this->len) {
                Cell tmp(curr.X() + i, curr.Y());
                pos.push_back(tmp);
            }
            if (curr.Y() + i >= 0 && curr.Y() + i < this->len) {
                Cell tmp(curr.X(), curr.Y() + i);
                pos.push_back(tmp);
            }
        }
        return pos;
    }

public:
    Maze(const string& s) : len(this->get_maze_size(s)), maze(len, vector<int> (len, 0)) {
        this->parse_maze(s);
    }

    vector<vector<int>> distances(Cell start, Cell finish) {
        vector<vector<bool>> visited(this->len, vector<bool>(this->len, false));
        vector<vector<int>> distances(this->len, vector<int>(this->len, INT_MAX));
        PriorityQueue p(distances);

        distances[start.X()][start.Y()] = 0;
        visited[start.X()][start.Y()] = true;

        Cell curr_cell = start;
        while (curr_cell.X() != -1 && curr_cell.Y() != -1) {
            for (Cell i : this->get_new_positions(curr_cell)) {
                if (!visited[i.X()][i.Y()]) {
                    p.add(i);
                }
                int tmp_dist = distances[curr_cell.X()][curr_cell.Y()] + abs(this->maze[i.X()][i.Y()] - this->maze[curr_cell.X()][curr_cell.Y()]);
                if (distances[i.X()][i.Y()] > tmp_dist) {
                    distances[i.X()][i.Y()] = tmp_dist;
                }
            }

            curr_cell = p.pop(visited, maze);
        }

        return distances;
    }

    vector<vector<int>>& get_maze() { return this->maze; }
    int get_size() { return this->len; }
};

int main()
{
    std::string s6 = "0000000000\n1111111111\n2222222222\n3333333333\n4444444444\n5555555555\n6666666666\n7777777777\n8888888888\n9999999999";

    Maze a(s6);
    Cell a1(0,0);
    Cell b1(1,1);
    vector<vector<int>> m = a.distances(a1, b1);
    cout << "Distacnce: " << m[a.get_size() - 1][a.get_size() - 1] << '\n';
    for (vector<int> i : a.distances(a1, b1)) {
        for (int j : i) {
            cout << j << ' ';
        }
        cout << '\n';
    }
}
