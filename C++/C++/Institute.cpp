#include <iostream>
#include <vector>
#include <string>
#include <algorithm>
#include <cctype>

using namespace std;

class Institute {
private:
    string instituteName;
    string city;
    string state;
    string act;
    string ministry;

public:
    Institute() : instituteName(""), city(""), state(""), act(""), ministry("") {}

    Institute(const string& name, const string& city, const string& state, const string& act, const string& ministry)
        : instituteName(name), city(city), state(state), act(act), ministry(ministry) {}

    string getName() const { return instituteName; }
    string getCity() const { return city; }
    string getState() const { return state; }
    string getAct() const { return act; }
    string getMinistry() const { return ministry; }

    void display() const {
        cout << "=======================================================" << endl;
        cout << "Institute Name: " << getName() << endl;
        cout << "City: " << getCity() << endl;
        cout << "State: " << getState() << endl;
        cout << "Ministry: " << getMinistry() << endl;
        cout << "Act: " << getAct() << endl;
        cout << "=======================================================" << endl;
    }
};

vector<Institute> institutes = {
    Institute("Aligarh Muslim University", "Aligarh", "Uttar Pradesh",
              "Entry No. 63, Union list - The 7th schedule under Article 246 of the Constitution of India", "Ministry of Education"),
    Institute("Banaras Hindu University", "Varanasi", "Uttar Pradesh",
              "Entry No. 63, Union list - The 7th schedule under Article 246 of the Constitution of India", "Ministry of Education"),
    Institute("University of Delhi", "Delhi", "Delhi",
              "Entry No. 63, Union list - The 7th schedule under Article 246 of the Constitution of India", "Ministry of Education"),
    Institute("Atal Bihari Vajpayee Indian Institute of Information Technology and Management, Gwalior", "Gwalior", "Madhya Pradesh",
              "The Indian Institutes of Information Technology Act, 2014 and their subsequent amendments", "Ministry of Education"),
    Institute("Indian Institute of Information Technology, Allahabad", "Allahabad", "Uttar Pradesh",
              "The Indian Institutes of Information Technology Act, 2014 and their subsequent amendments", "Ministry of Education")
};

string toLower(const string& str) {
    string lowerStr = str;
    transform(lowerStr.begin(), lowerStr.end(), lowerStr.begin(), ::tolower);
    return lowerStr;
}

void searchByName(const string& name) {
    bool found = false;
    string lowerName = toLower(name);
    for (const auto& inst : institutes) {
        if (toLower(inst.getName()) == lowerName) {
            inst.display();
            found = true;
        }
    }
    if (!found) {
        cout << "Institute not found." << endl;
    }
}

void searchByCity(const string& city) {
    bool found = false;
    string lowerCity = toLower(city);
    for (const auto& inst : institutes) {
        if (toLower(inst.getCity()) == lowerCity) {
            inst.display();
            found = true;
        }
    }
    if (!found) {
        cout << "Institute not found." << endl;
    }
}

void searchByState(const string& state) {
    bool found = false;
    string lowerState = toLower(state);
    for (const auto& inst : institutes) {
        if (toLower(inst.getState()) == lowerState) {
            inst.display();
            found = true;
        }
    }
    if (!found) {
        cout << "Institute not found." << endl;
    }
}

void addNewInstitute() {
    string name, city, state, act, ministry;

    cout << "Enter the name of the institute: ";
    getline(cin, name);
    cout << "Enter City of the institute: ";
    getline(cin, city);
    cout << "Enter State of the institute: ";
    getline(cin, state);
    cout << "Enter Act of the institute: ";
    getline(cin, act);
    cout << "Enter Ministry of the institute: ";
    getline(cin, ministry);

    Institute newInstitute(name, city, state, act, ministry);
    institutes.push_back(newInstitute);
    cout << "New institute added successfully." << endl;
}

void displayAllInstitutes() {
    if (institutes.empty()) {
        cout << "No institutes available." << endl;
    } else {
        for (const auto& inst : institutes) {
            inst.display();
        }
    }
}

int main() {
    int choice;

    do {
        cout << "=======================================================" << endl;
        cout << "PRESS" << endl;
        cout << "1. To Display all Institutes" << endl;
        cout << "2. To Search an Institute" << endl;
        cout << "3. To Add a New Institute" << endl;
        cout << "0. To Exit" << endl;
        cout << "=======================================================" << endl;
        cin >> choice;
        cin.ignore(); // To ignore the newline character left in the buffer

        switch (choice) {
            case 1:
                displayAllInstitutes();
                break;
            case 2: {
                int searchChoice;
                cout << "PRESS" << endl;
                cout << "1. To Search by Name" << endl;
                cout << "2. To Search by City" << endl;
                cout << "3. To Search by State" << endl;
                cout << "0. To Exit" << endl;
                cin >> searchChoice;
                cin.ignore(); // To ignore the newline character left in the buffer

                switch (searchChoice) {
                    case 1: {
                        string name;
                        cout << "Enter name of the institute to search: ";
                        getline(cin, name);
                        searchByName(name);
                        break;
                    }
                    case 2: {
                        string city;
                        cout << "Enter the city: ";
                        getline(cin, city);
                        searchByCity(city);
                        break;
                    }
                    case 3: {
                        string state;
                        cout << "Enter the state: ";
                        getline(cin, state);
                        searchByState(state);
                        break;
                    }
                    case 0:
                        cout << "Returning to main menu..." << endl;
                        break;
                    default:
                        cout << "Invalid choice. Please try again." << endl;
                        break;
                }
                break;
            }
            case 3:
                addNewInstitute();
                break;
            case 0:
                cout << "Exiting..." << endl;
                break;
            default:
                cout << "Invalid choice. Please try again." << endl;
                break;
        }
    } while (choice != 0);

    return 0;
}
