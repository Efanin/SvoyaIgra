namespace WinFormsApp4
{
    public partial class Form1 : Form
    {
        private List<Button> buttons;
        public Form1()
        {
            InitializeComponent();
            questions = new()
            {
                question1,
                question2,
                question3,
                question4,
                question5
            };
            buttons = new() {
                button1,button2,button3,button4,button5,button6,button7,button8,button9,button10,button11,button12,button13,button14,button15,button16,button17,button18,button19,button20,button21,button22,button23,button24,button25
            };
        }
        private List<string[]> questions;
        private string[] question1 =
        {
            "Какой самый \"ленивый\" \nспособ написать программу?",
            "ctrl+c ctrl+v",
            "Как отличить \"целое число\" \nот \"дробного\"?",
            ",",
            "Как можно назвать класс который \nнаследуется непонятно от кого?",
            "Приемный",
            "Если своеобразно перевести \n\"тлеющие угли в заднице\", \nто получится этот язык программирования",
            "assembler",
            "Что получится, если сложить \nдва \"булевых\" значения?",
            "Да"

        };
        private string[] question2 =
        {
            "Эта простая фраза, которая \nвыводится на экран при запуске \nмногих программ, стала своего рода \n\"традицией\" в программировании.",
            "Hello world",
            "Изначально это слово означало\nталантливого программиста, \nно со временем оно стало ассоциироваться \nс людьми, которые взламывают системы.",
            "Хакер",
            "В 1947 году мотылек попал \nв компьютер и вызвал сбой в работе, \nпосле этого случая ошибку\nстали называть?",
            "Bug",
            "в 1972 году появился этот\n язык программирования и образовало целое \nсемейство языков, \nкак называется это семейство?",
            "Cемейство С",
            "Конкурс \nКто назовёт ближайшее число\n\nВ каком году появился первый \nвысокоуровневый язык программирования?",
            "1954"
        };
        private string[] question3 =
        {
            "Cuphead, Escape from Tarkov,\n Hollow knight, Hearthstone\n именно эти игры были написаны на этом \nязыке программирования",
            "C#",
            "На каком языке была написана игра DOOM",
            "C",
            "В этой игре размер мира больше земли в 5 раз,\nв ней можно программировать,\nа чтобы ее запустить вам нужна чашка кофе?",
            "Minecraft",
            "Назовите технологию, которая\nпозволяет создать максимально \nреалистичную графику в играх?",
            "Ray tracing",
            "Эта считается первой компьютерной игрой,\nеё создал Уильям Хинтц в 1958 году",
            "Теннис для двоих"
        };
        private string[] question4 =
        {
            "Какой популярный игровой \nдвижок использует язык с#?",
            "Unity",
            "В языке c# используются\nфункции или методы?",
            "Методы",
            "Язык c# использует \nкомпилятор или интерпретатор?",
            "Компилятор",
            "Аукцион",
            "ФИО Преподавателя?",
            "Конкурс, кто назовёт ближайшее число\n\nВ каком году появился \nязык программирования С#?",
            "1998"
        };
        private string[] question5 =
        {
            "Что такое IT?",
            "Информационные технологии",
            "Кот в мешке",
            "Что такое операционная система?",
            "Что такое DDoS?",
            "Распределенный отказ от обслуживания",
            "Н О Д Т Ч П Ш С В Д \nНазовите следующею букву?",
            "Д",
            "Самое большое число?",
            "1"
        };
        
        private void label3_Click(object sender, EventArgs e)
        {

        }
        private Form2 form2;
        private void question(int group, int lvl)
        {
            form2 = new();
            form2.Show();
            form2.question = questions[group][lvl * 2];
            form2.answer = questions[group][lvl * 2 + 1];
            form2.show();
        }

        private void button25_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < buttons.Count; i++)
                if (buttons[i] == sender)
                {
                    question(i / 5, i % 5);
                    buttons[i].Visible = false;
                }
        }
    }
}
