public class Solution {
public string Convert(string s, int numRows) {
    int roundRows = numRows * 2 - 2;
    if (roundRows == 0)
        roundRows++;
    return new string(
        s.Select((c, i) => new txt()
        {
            c = c,
            Hori = i / roundRows,
            Hori2 = i % roundRows >= numRows ? roundRows - (i % roundRows) : (i % roundRows)
        }).OrderBy(x => x.Hori2).ThenBy(x => x.Hori).Select(x => x.c).ToArray()
    );
}

public class txt
{
    public char c;
    public int Hori;
    public int Hori2;
}
}