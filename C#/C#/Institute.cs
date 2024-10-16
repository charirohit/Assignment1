using System;
using System.Collections.Generic;

public class Institute
{
    private string instituteName;
    private string city;
    private string state;
    private string act;
    private string ministry;

    public Institute() { }

    public Institute(string name, string city, string state, string act, string ministry)
    {
        this.instituteName = name;
        this.city = city;
        this.state = state;
        this.act = act;
        this.ministry = ministry;
    }

    public string GetName() => this.instituteName;
    public string GetCity() => this.city;
    public string GetState() => this.state;
    public string GetAct() => this.act;
    public string GetMinistry() => this.ministry;

    public void Display()
    {
        Console.WriteLine("=======================================================");
        Console.WriteLine($"Institute Name: {this.GetName()}");
        Console.WriteLine($"City: {this.GetCity()}");
        Console.WriteLine($"State: {this.GetState()}");
        Console.WriteLine($"Ministry: {this.GetMinistry()}");
        Console.WriteLine($"Act: {this.GetAct()}");
        Console.WriteLine("=======================================================");
    }
}

public class StartInstitute
{
    private static readonly List<Institute> institutes = new List<Institute>
    {
        new Institute("Aligarh Muslim University", "Aligarh", "Uttar Pradesh",
                      "Entry No. 63, Union list - The 7th schedule under Article 246 of the Constitution of India", "Ministry of Education"),
        new Institute("Banaras Hindu University", "Varanasi", "Uttar Pradesh",
                      "Entry No. 63, Union list - The 7th schedule under Article 246 of the Constitution of India", "Ministry of Education"),
        new Institute("University of Delhi", "Delhi", "Delhi",
                      "Entry No. 63, Union list - The 7th schedule under Article 246 of the Constitution of India", "Ministry of Education"),
        new Institute("Atal Bihari Vajpayee Indian Institute of Information Technology and Management, Gwalior", "Gwalior", "Madhya Pradesh",
                      "The Indian Institutes of Information Technology Act, 2014 and their subsequent amendments", "Ministry of Education"),
        new Institute("Indian Institute of Information Technology, Allahabad", "Allahabad", "Uttar Pradesh",
                      "The Indian Institutes of Information Technology Act, 2014 and their subsequent amendments", "Ministry of Education")
    };

    public static void Main(string[] args)
    {
        int choice;

        do
        {
            Console.WriteLine("=======================================================");
            Console.WriteLine("PRESS");
            Console.WriteLine("1. To Display all Institutes");
            Console.WriteLine("2. To Search an Institute");
            Console.WriteLine("3. To Add a New Institute");
            Console.WriteLine("0. To Exit");
            Console.WriteLine("=======================================================");
            choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    DisplayAllInstitutes();
                    break;
                case 2:
                    SearchInstitute();
                    break;
                case 3:
                    AddNewInstitute();
                    break;
                case 0:
                    Console.WriteLine("Exiting...");
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        } while (choice != 0);
    }

    private static void DisplayAllInstitutes()
    {
        if (institutes.Count == 0)
        {
            Console.WriteLine("No institutes available.");
        }
        else
        {
            foreach (Institute inst in institutes)
            {
                inst.Display();
            }
        }
    }

    private static void SearchInstitute()
    {
        Console.WriteLine("PRESS");
        Console.WriteLine("1. To Search by Name");
        Console.WriteLine("2. To Search by City");
        Console.WriteLine("3. To Search by State");
        Console.WriteLine("0. To Exit");
        int searchChoice = int.Parse(Console.ReadLine());

        switch (searchChoice)
        {
            case 1:
                Console.WriteLine("Enter name of the institute to search:");
                string name = Console.ReadLine();
                SearchByName(name);
                break;
            case 2:
                Console.WriteLine("Enter the city:");
                string city = Console.ReadLine();
                SearchByCity(city);
                break;
            case 3:
                Console.WriteLine("Enter the state:");
                string state = Console.ReadLine();
                SearchByState(state);
                break;
            case 0:
                Console.WriteLine("Returning to main menu...");
                break;
            default:
                Console.WriteLine("Invalid choice. Please try again.");
                break;
        }
    }

    private static void SearchByName(string name)
    {
        bool found = false;
        foreach (Institute inst in institutes)
        {
            if (inst.GetName().Equals(name, StringComparison.OrdinalIgnoreCase))
            {
                inst.Display();
                found = true;
            }
        }
        if (!found)
        {
            Console.WriteLine("Institute not found.");
        }
    }

    private static void SearchByCity(string city)
    {
        bool found = false;
        foreach (Institute inst in institutes)
        {
            if (inst.GetCity().Equals(city, StringComparison.OrdinalIgnoreCase))
            {
                inst.Display();
                found = true;
            }
        }
        if (!found)
        {
            Console.WriteLine("Institute not found.");
        }
    }

    private static void SearchByState(string state)
    {
        bool found = false;
        foreach (Institute inst in institutes)
        {
            if (inst.GetState().Equals(state, StringComparison.OrdinalIgnoreCase))
            {
                inst.Display();
                found = true;
            }
        }
        if (!found)
        {
            Console.WriteLine("Institute not found.");
        }
    }

    private static void AddNewInstitute()
    {
        Console.WriteLine("Enter the name of the institute:");
        string name = Console.ReadLine();
        Console.WriteLine("Enter City of the institute:");
        string city = Console.ReadLine();
        Console.WriteLine("Enter State of the institute:");
        string state = Console.ReadLine();
        Console.WriteLine("Enter Act of the institute:");
        string act = Console.ReadLine();
        Console.WriteLine("Enter Ministry of the institute:");
        string ministry = Console.ReadLine();

        Institute newInstitute = new Institute(name, city, state, act, ministry);
        institutes.Add(newInstitute);
        Console.WriteLine("New institute added successfully.");
    }
}
