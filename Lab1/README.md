### README.md

# Principles Demonstrated

## SOLID Principles

1. **Single Responsibility Principle (SRP)**:
   - Each class has a single responsibility: `Money` manages money, `Product` manages product details, `Warehouse` manages inventory, and `Reporting` handles reports.
    
2. **Open/Closed Principle (OCP)**:
   - Classes are open for extension but closed for modification. For instance, `Product` and `Money` can be extended without modifying existing code.
    
3. **Liskov Substitution Principle (LSP)**:
   - Not explicitly demonstrated here but could be applied by using base classes or interfaces if inheritance were used.
     
4. **Interface Segregation Principle (ISP)**:
   - The implementation uses classes with focused responsibilities, avoiding large, unfocused interfaces.

5. **Dependency Inversion Principle (DIP)**:
   - `Reporting` depends on the `Warehouse` abstraction rather than concrete implementation, allowing for easier testing and extension.

  
  ## Other Principles
1.  **DRY (Don't Repeat Yourself)**:
   - Avoids repetition by centralizing logic within classes and methods. The `AddProduct`, `RemoveProduct`, and `FindProduct` methods in `Warehouse` prevent code duplication.
     
2. **KISS (Keep It Simple, Stupid)**:
   - The code is straightforward and clear. Classes and methods are kept small and focused on specific tasks.
     
3. **YAGNI (You Aren't Gonna Need It)**:
   - Only necessary methods are implemented without over-engineering. For example, `Product` has only the `DecreasePrice` method besides the constructor and properties.
     
4. **Composition Over Inheritance**:
   - `Warehouse` uses a composition of `Product` objects in a list instead of inheritance, making it more flexible and easier to maintain.

5. **Program to Interfaces, not Implementations**:
   - Methods like `AddProduct` and `GenerateReceipt` interact with objects through abstract interfaces rather than concrete classes, allowing for flexible implementations and easier testing.

6. **Fail Fast**:
   - Input validation in constructors and methods ensures that the application fails quickly and clearly if invalid data is provided, avoiding hidden bugs and undefined states.
    
[Money.cs](Money.cs)
[Product.cs](Product.cs)
[Program.cs](Program.cs)
[Reporting.cs](Reporting.cs)
[Warehouse.cs](Warehouse.cs)
