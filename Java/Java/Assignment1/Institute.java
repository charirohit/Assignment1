/**
 * @author Rohit Chari
 * @Rollno 09
 * @version 1.0
 * @since 17 july 2024
 * @Modified 31 july 2024
 */
///**This project is done with referance of institutes of Education in India
// * The classes and objects created are deduced through the website of higer education of india
// * for the project I've created two java classes one is the actual institute class and the other is to create instances of the class and to provise an menu driven approch for the user
// * THIS IS THE ACTUAL 'INSTITUTE ' CLASS
// **/


public class Institute {                                                                                         //Here the class is started
    
    private String instituteName,city,state,ministry,act;                                                  //Declaring varibles for the class

    public Institute(){                                                                                          //Default constructor for the class
        
        this.instituteName="";
        
        this.city="";
        this.state="";
        this.ministry="";
       
    }

    public Institute(String name){                                                                               //Constructor with one value
        
        this.instituteName=name;
        
    }

    public Institute(String name,String city,String state){                                                      //Constructor with three value
        
        this.instituteName=name;
        
        this.city=city;
        this.state=state;
    }

    public Institute(String name,String city,String state,String Act,String ministry){              //Constructor with all the value
        
        this.instituteName=name;
        
        this.city=city;
        this.state=state;
        this.ministry=ministry;
        
        this.act=Act;
    }

    

    public String getName(){                                                                                   //Declaring getter methods for the variables
        return this.instituteName;
    }

    

    public String getCity(){
        return this.city;
    }

    public String getState(){
        return this.state;
    }

    public String getMinistry(){
        return this.ministry;
    }

    public String getAct(){
        return this.act;
    }

    public void display(){                                                                                    //Declaring Display method to print all the values
        
        System.out.println("=======================================================");
        System.out.println("Institute Name : "+this.getName());
        System.out.println("City : "+this.getCity());
        System.out.println("State : "+this.getState());
        System.out.println("Ministry : "+this.getMinistry());
        System.out.println("Act : " + this.getAct());
        System.out.println("=======================================================");
    }
}
