namespace QuestionBankEntities;

public class QuestionTitle:IComparable
{
    public int id { get; set; }
    public string title { get; set; }

    public int CompareTo(object? obj)
    {
        QuestionTitle secondQuestion = obj as QuestionTitle; 
        return secondQuestion.id.CompareTo(id);
    }
}
