namespace exercise2;

public class Program
{
    static void Main()
    {
        // Create todo list
        ToDoList myTodoList = new ToDoList("Ken");
        myTodoList.Add(new("Todo1", new DateTime(2024, 10, 22), Priority.High));
        myTodoList.Add(new("Todo2", new DateTime(2024, 11, 1), Priority.Medium));
        myTodoList.Add(new("Todo3", new DateTime(2024, 12, 25), Priority.Low));

        for (int i = 0; i < myTodoList.Length; i++)
        {
            Console.WriteLine(myTodoList[i]);
        }

        myTodoList[0].ToXML("todo.xml");
    }
}
