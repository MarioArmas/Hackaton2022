using System.Globalization;
using System.Text;

Console.WriteLine("Ingresar Texto");
string text = removeDiacritics(Console.ReadLine()).ToUpper();

Console.WriteLine("Hay " + countVocals(text) + " vocales :D");

int countVocals(string _text) {
    int counter = 0;
    string dic = "AEIOU";
    
    for (int j = 0; j < _text.Length; j++) {
        for (int i = 0; i < dic.Length; i++) {
            if (_text[j] == dic[i]) {
                counter++;
            }
        }
    }

    return counter;
}

string removeDiacritics(string text) {
    var normalizedString = text.Normalize(NormalizationForm.FormD);
    var stringBuilder = new StringBuilder();

    foreach (var c in normalizedString.EnumerateRunes()) {
        var unicodeCategory = Rune.GetUnicodeCategory(c);
        if (unicodeCategory != UnicodeCategory.NonSpacingMark) {
            stringBuilder.Append(c);
        }
    }

    return stringBuilder.ToString().Normalize(NormalizationForm.FormC);
}