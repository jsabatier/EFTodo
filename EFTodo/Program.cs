using (var context = new TodoContext())
{
    Console.WriteLine("--- Inserting a new todo ---");
    context.Add(new Todo {});
    context.SaveChanges();

    Console.WriteLine("--- Retrieve teh todo with lowest id ---");
    var todo = context.Todo
        .OrderBy(b => b.Id)
        .First();

    Console.WriteLine("--- Updating the blog and adding a post ---");
    todo.Task = "Faire le ménage";
    
    
    context.SaveChanges();

    Console.WriteLine("--- Deleting the blog ---");
    context.Remove(todo);
    context.SaveChanges();
}
