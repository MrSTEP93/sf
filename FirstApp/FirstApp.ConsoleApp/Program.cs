using static ConsoleHelper.Helper;

namespace FirstApp.ConsoleApp
{
    internal class Program
    {
        public static bool YesOrNo(string question, string positiveReply, string negativeReply)
        {
            WriteLn(question,true);
            string answerYN = ReadLn().ToLower();
            if ((answerYN == "да") & (answerYN == "yes"))
            {
                WriteLn(positiveReply);
                return true;
            }
            else
            {
                WriteLn(negativeReply);
                return false;
            }
        }
        static void Main(string[] args)
        {
            
            WriteLn("Здравствуйте, студент. Как Вас зовут? (введите ответ после двух угловых скобок)", true);
            string name = ReadLn();
            WriteLn($"Здравствуйте, {name}");
            bool answer = YesOrNo($"Вы уже знакомы с IT, {name}?", "Вау!", "Жаль... Было бы здорово разбираться в общих понятиях" +
                ", чтобы учиться на разработчика. Но надеюсь, что вы сможете достигнуть результатов и так!!! Удачи!");
            if (answer)
            {
                answer = YesOrNo("А с языком C# ??", $"{name}, вы выглядите достаточно умным!", "Именно для изучения его мы здесь и собрались!");
                if (answer)
                {
                    WriteLn($"Так зачем вы учитесь, {name}?", true);
                    ReadLn();
                    WriteLn("Удачи в достижениии поставленных целей!!!");
                }
            }
            WriteLn("До свидания!");
        }
    }
}