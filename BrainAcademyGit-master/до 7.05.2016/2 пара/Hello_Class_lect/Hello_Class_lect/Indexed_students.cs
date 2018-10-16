class Indexed_students
{
    private string[] stud_list = new string[stud_cnt];
    static public int stud_cnt = 8;
    public Indexed_students()
    {
        for (int j = 0; j < stud_cnt; j++)
            stud_list[j] = "C# student";
    }

    public string this[int index_var]
    {
        get
        {
            string temp;
            if (index_var >= 0 && index_var <= stud_cnt - 1)
            {
                temp = stud_list[index_var];
            }
            else
            {
                temp = "";
            }
            return (temp);
        }
        set
        {
            if (index_var >= 0 && index_var <= stud_cnt - 1)
            {
                stud_list[index_var] = value;
            }
        }
    }
}
