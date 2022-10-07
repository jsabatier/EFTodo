using (var context = new TodoContext())
{
    /*Console.WriteLine("--- Inserting a new todo ---");
    context.Add(new Todo{Task ="Faire le ménage",Completed=false});
    context.SaveChanges();
    Console.WriteLine("--- Inserting a new todo ---");
    context.Add(new Todo{Task ="Sortir les poubelles",Completed=false});
    context.SaveChanges();
    Console.WriteLine("--- Inserting a new todo ---");
    context.Add(new Todo{Task ="Aller acheter un chat",Completed=true});
    context.SaveChanges();*/

    var todos = context.Todo
            .ToList();
    
    //Console.WriteLine("--- Liste de tout les todos---");
    foreach (Todo item in todos)
    {
        context.Remove(item);
        //Console.WriteLine("Todo{0}, task : {1} completed : {2}",item.Id, item.Task, item.Completed);
    }
    
    /*var afaire = context.Todo
            .Where(b => b.Completed ==false)
            .ToList();

    foreach (Todo item in afaire)
    {
        item.Completed =true;
        context.SaveChanges();
        //Console.WriteLine("Todo{0}, task : {1} completed : {2}",item.Id, item.Task, item.Completed);
    }*/

    
    context.SaveChanges();
    
}
