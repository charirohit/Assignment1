class Institute:
    def __init__(self, name="", city="", state="", act="", ministry=""):
        self.institute_name = name
        self.city = city
        self.state = state
        self.act = act
        self.ministry = ministry

    def get_name(self):
        return self.institute_name

    def get_city(self):
        return self.city

    def get_state(self):
        return self.state

    def get_act(self):
        return self.act

    def get_ministry(self):
        return self.ministry

    def display(self):
        print("="*50)
        print(f"Institute Name: {self.get_name()}")
        print(f"City: {self.get_city()}")
        print(f"State: {self.get_state()}")
        print(f"Ministry: {self.get_ministry()}")
        print(f"Act: {self.get_act()}")
        print("="*50)


def main():
    institutes = [
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
    ]

    while True:
        print("="*50)
        print("PRESS")
        print("1. To Display all Institutes")
        print("2. To Search an Institute")
        print("3. To Add a New Institute")
        print("0. To Exit")
        
        choice = int(input().strip())
        
        if choice == 1:
            if not institutes:
                print("No institutes available.")
            else:
                for inst in institutes:
                    inst.display()
        elif choice == 2:
            print("PRESS")
            print("1. To Search by Name")
            print("2. To Search by City")
            print("3. To Search by State")
            print("0. To Exit")
            
            search_choice = int(input().strip())

            if search_choice == 1:
                print("Enter name of the institute to search:")
                name = input().strip()
                found = False
                for inst in institutes:
                    if inst.get_name().lower() == name.lower():
                        inst.display()
                        found = True
                if not found:
                    print("Institute not found.")
            elif search_choice == 2:
                print("Enter the city:")
                city = input().strip()
                found = False
                for inst in institutes:
                    if inst.get_city().lower() == city.lower():
                        inst.display()
                        found = True
                if not found:
                    print("Institute not found.")
            elif search_choice == 3:
                print("Enter the state:")
                state = input().strip()
                found = False
                for inst in institutes:
                    if inst.get_state().lower() == state.lower():
                        inst.display()
                        found = True
                if not found:
                    print("Institute not found.")
            elif search_choice == 0:
                print("Returning to main menu...")
            else:
                print("Invalid choice. Please try again.")
        elif choice == 3:
            print("Enter the name of the institute:")
            name = input().strip()
            print("Enter City of the institute:")
            city = input().strip()
            print("Enter State of the institute:")
            state = input().strip()
            print("Enter Act of the institute:")
            act = input().strip()
            print("Enter Ministry of the institute:")
            ministry = input().strip()

            new_institute = Institute(name, city, state, act, ministry)
            institutes.append(new_institute)
            print("New institute added successfully.")
        elif choice == 0:
            print("Exiting...")
            break
        else:
            print("Invalid choice. Please try again.")


if __name__ == "__main__":
    main()
