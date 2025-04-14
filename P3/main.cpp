#include <iostream>
#include <fstream>
#include <sstream>
#include <cmath>
#include <ctime>
#include <string>
#include <iomanip>

//source code dari chatgpt

using namespace std;

double degToRad(double deg) {
    return deg * M_PI / 180.0;
}

double acosDeg(double val) {
    return acos(val) * 180.0 / M_PI;
}


double hitungWaktu(double latitude, double decl, double eqTime, double longit, double sudut) {
    double cosH = (cos(degToRad(90 + sudut)) - sin(degToRad(latitude)) * sin(degToRad(decl))) /
                  (cos(degToRad(latitude)) * cos(degToRad(decl)));

    double H = acosDeg(cosH) / 15.0;  // dalam jam
    double D = 12 - H;                // waktu UTC tengah hari - H
    double waktu = D - (longit / 15.0) + (eqTime / 60.0);

    return waktu;
}

string floatToTime(double jam) {
    int h = (int)jam;
    int m = (int)((jam - h) * 60);
    ostringstream ss;
    ss << setfill('0') << setw(2) << h << ":" << setw(2) << m;
    return ss.str();
}

int main() {
    string tanggal;
    double latitude, longitude;
    cout << "Masukkan tanggal (YYYY-MM-DD): ";
    cin >> tanggal;
    cout << "Latitude: ";
    cin >> latitude;
    cout << "Longitude: ";
    cin >> longitude;

    ifstream file("ephemeris.csv");
    string line;
    bool found = false;
    double decl, eq;

    while (getline(file, line)) {
        if (line.find(tanggal) != string::npos) {
            stringstream ss(line);
            string temp;
            getline(ss, temp, ','); // tanggal
            getline(ss, temp, ','); decl = stod(temp);
            getline(ss, temp, ','); eq = stod(temp);
            found = true;
            break;
        }
    }

    if (!found) {
        cout << "Data ephemeris tidak ditemukan." << endl;
        return 1;
    }

   
    double waktuSubuh = hitungWaktu(latitude, decl, eq, longitude, 18);
    double waktuMaghrib = hitungWaktu(latitude, decl, eq, longitude, -0.833);

    cout << "\nWaktu Sholat untuk " << tanggal << endl;
    cout << "Subuh   : " << floatToTime(waktuSubuh) << " (UTC)\n";
    cout << "Maghrib : " << floatToTime(waktuMaghrib) << " (UTC)\n";

    return 0;
}
