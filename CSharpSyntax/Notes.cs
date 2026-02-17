using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Threading.Tasks;

namespace Week1TestClass.CSharpSyntax
{
    public class Notes
    {
        /// Today 25-01-2026 Four pillars of OOP
        /// 1. Encapsulation:
        ///   - Bundling data and methods that operate on that data within a single unit (class).
        /// We have seen how this is implemented in the Car class with private Mileage property.
        /// 
        /// 2. Abstraction:
        ///   - Hiding complex implementation details and exposing only the necessary parts.
        /// We have seen this in the ICar interface, which exposes only essential methods.
        /// 
        /// 3. Inheritance:
        ///   - Creating new classes based on existing ones, inheriting properties and methods.
        /// We have seen this in the Car class inheriting from SedanSUV class.
        /// 
        /// 4. Polymorphism:
        ///   - Ability to present the same interface for different underlying forms (data types).
        /// We have seen this in method overloading in the Car class with multiple Drive methods.
        /// 
        /// Generics:
        /// - Allow you to define classes, interfaces, and methods with a placeholder for the data type.
        /// 
        /// Arrays vs Lists:
        /// - Arrays have a fixed size, while Lists can dynamically resize.
        /// - Lists provide more built-in methods for manipulation (like Add, Remove, etc.).
        /// 
        /// 
        /// 
        /// SOLID Principles:
        /// 1. Single Responsibility Principle (SRP): A class should have only one reason to change.
        /// 2. Open/Closed Principle (OCP): Software entities should be open for extension but closed for modification.
        /// 3. Liskov Substitution Principle (LSP): Subtypes must be substitutable for their base types.
        /// 4. Interface Segregation Principle (ISP): Clients should not be forced to depend on interfaces they do not use.
        /// 5. Dependency Inversion Principle (DIP): High-level modules should not depend on low-level modules. Both should depend on abstractions.

        string name = "Samuel";
        int age = 30;

        int[] scoresArray = new int[] { 85, 90, 78 }; // Array

        int[] scores = new int[5]; // Array with fixed size
        //scores[0] = 85;

        // Demonstrating an array method
        public int[] GetScoresArray()
        {
            scores[0] = 85;
            scores[1] = 90;
            scores[2] = 78;
            scores[3] = 95;
            scores[4] = 88;

            scores.Append(98);

            scores[0] = 100;
            return scores;
        }

        public List<int> ScoreList()
        {
            List<int> scoresList = new List<int> { 85, 90, 78 }; // List
            scoresList.Add(95);
            return scoresList;
        }

        public List<string> Names()
        {
            List<string> names = new List<string> { "Alice", "Bob", "Charlie" };
            names.Add("Diana");
            names.Remove("Bob");
            return names;
        }

        // ArrayList vs List<T>:
        // - ArrayList can hold items of any data type, while List<T> is strongly typed.
        // - List<T> provides better performance and type safety.

        // Demonstrating ArrayList
        public ArrayList GetArrayList()
        {
            ArrayList arrayList = new ArrayList();
            arrayList.Add(85);
            arrayList.Add("Ninety");
            arrayList.Add(78.5);
            arrayList.Add(true);

            arrayList[0] = 100;
            arrayList.Remove("Ninety");
            return arrayList;
        }

        // Demonstrating a generic method

        public T GetDefaultValue<T>(T value)
        {
            return value;
        }
        // Demonstrating non-generic method
        public int GetDefaultIntValue()
        {
            string name = "Samuel";
            int age = 30;
            //return default(int);
            return age;
        }


        // Phase II 
        // LINQ fundamentals and IEnumerable patterns

        // What is LINQ?
        // - Language Integrated Query (LINQ) is a powerful feature in C# that allows you to query collections in a concise and readable manner.
        // - It provides a consistent way to work with data from different sources (like arrays, lists, databases, XML, etc.) using a unified syntax.

        // Basic LINQ Operations:
        // - Filtering: Using the 'where' clause to filter elements based on a condition.   
        // - Projection: Using the 'select' clause to transform data into a new form.


        // Join
        // When data is split accross different collections, jjust like tables in a database.

        // Types of Joins:
        // - Inner Join: Returns only the records that have matching values in both collections.
        // - Left Join: Returns all records from the left collection and the matched records from the right collection. If there is no match, the result is null on the right side.

        // Assignment: Implement the right join and full outer join in the Admin class.

        // - Right Join: Returns all records from the right collection and the matched records from the left collection. If there is no match, the result is null on the left side.
        // - Full Outer Join: Returns all records when there is a match in either left or right collection. If there is no match, the result is null on the side that does not have a match.


        // Grouping:
        // - Grouping: Using the 'group by' clause to group elements based on a key.
        // - Aggregation: Using aggregate functions (like Count, Sum, Average, etc.) to perform calculations on grouped data.

        






        // Relationships 

        // One-to-One: Each record in one collection is associated with exactly one record in another collection. (e.g., User and Car)
        // One-to-Many: A record in one collection can be associated with multiple records in another collection. (e.g., User and Orders)
        // Many-to-Many: Records in one collection can be associated with multiple records in another collection, and vice versa. (e.g., Students and Courses)




    }
}