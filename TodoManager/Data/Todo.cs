namespace TodoManager.Data;

public class Todo
{
    public string Title { get; set; }
    public string Text { get; set; }
    public bool IsCompleted { get; set; }
    
    public void ToggleIsCompleted()
    {
        IsCompleted = !IsCompleted;
    }
}

public class TodoBuilder()
{
    Todo todo = new Todo();

    public TodoBuilder SetTitle(string title)
    {
        todo.Title = title;
        return this;
    }
    
    public TodoBuilder SetText(string text)
    {
        todo.Text = text;
        return this;
    }
    
    public TodoBuilder SetIsCompleted(bool isCompleted)
    {
        todo.IsCompleted = isCompleted;
        return this;
    }
    
    public Todo Build()
    {
        return todo;
    }
}