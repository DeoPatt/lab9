using System;

class MainClass {
  public static void Main (string[] args) {
    
  Employee unknown = new Employee();
  unknown.Intro();
   Employee John = new Employee("john", "smith", "1234",45);
   John.Intro();
  }
}