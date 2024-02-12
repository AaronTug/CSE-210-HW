using System;
using System.Data;
using System.Globalization;

class Reference
{

    private List<string> references = new List<string>();
    private void buildList()
    {

        references.Add("1 Nephi 3:7");

        references.Add("D&C 8: 2-3");
    }

    public string getReference(int loc)
    {
        return (references[loc]);
    }


}