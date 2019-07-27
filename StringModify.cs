using static System.Console;

namespace StringModify
{
    public class MainApp
    {
        static void Main(string[] args)
        {
            // ToLower() : 현재 문자열의 모든 대문자를 소문자로 바꾼 새 문자열 반환.
            // ToUpper() : 현재 문자열의 모든 소문자를 대문자로 바꾼 새 문자열 반환.

            WriteLine("Lower() : '{0}'", "ABC".ToLower());
            WriteLine("ToUpper() : '{0}'", "abc".ToUpper());

            // Insert() : 현재 문자열의 지정된 위치에 지정된 문자열이 삽입된 새 문자열을 반환.
            // Remove() : 현재 문자열의 지정된 위치로부터 지정된 수만큼의 문자가 삭제된 새 문자열을 반환.

            WriteLine("Insert() : '{0}'", "Happy Friday!".Insert(5, "Sunny"));
            WriteLine("Remove() : '{0}'", "I Don't Love You.".Remove(2, 6));

            // Trim() : 현재 문자열의 앞 / 뒤에 있는 공백을 삭제한 새 문자열을 반환한다.
            // TrimStart() : 현재 문자열의 앞에 있는 공백을 삭제한 새 문자열을 반환한다.
            // TrimEnd() : 현재 문자열의 뒤에 있는 공백을 삭제한 새 문자열을 반환한다.

            WriteLine("Trim() : '{0}'", " No Spaces ".Trim());
            WriteLine("TrimStart() : '{0}'", " No Spaces ".TrimStart());
            WriteLine("TrimEnd() : '{0}'", "No Spaces ".TrimEnd());
        }
    }
}