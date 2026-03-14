using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Contracts;
using System.IO;

public class Diary
{
    public List<Page> _Page = new List<Page>();
    public void ReadDiary()
    {
        foreach (Page page in _Page)
        {
            page.DisplayQuestionEntry();
        }
    } 
    public void AddEntry(string entry,string question,string date)
    {
        Page page = new Page();
        page._question = question;
        page._entry = entry;
        page._time = date;

        _Page.Add(page);
    }

    public void SaveToFile(string fileName)
    {
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            foreach (Page page in _Page)
            {
                outputFile.Write(page._question);
                outputFile.Write("|");
                outputFile.Write(page._entry);
                outputFile.Write("|");
                outputFile.WriteLine(page._time);
            }
        }
    }

    public void LoadFile(string fileNameLoad)
    {
        string[] lines = System.IO.File.ReadAllLines(fileNameLoad);

        foreach(string line in lines)
        {
            if(line.Contains("&"))
            {
                break;
            }
            else
            {
                string[] chunk = line.Split("|");

                string question = chunk[0];
                string entry = chunk[1];
                string time = chunk[2];

                Page page = new Page();
                page._question = question;
                page._entry = entry;
                page._time = time;

                _Page.Add(page);
            }

        }
    }
}