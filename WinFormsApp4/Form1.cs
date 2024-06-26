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
            "����� ����� \"�������\" \n������ �������� ���������?",
            "ctrl+c ctrl+v",
            "��� �������� \"����� �����\" \n�� \"��������\"?",
            ",",
            "��� ����� ������� ����� ������� \n����������� ��������� �� ����?",
            "��������",
            "���� ����������� ��������� \n\"������� ���� � �������\", \n�� ��������� ���� ���� ����������������",
            "assembler",
            "��� ���������, ���� ������� \n��� \"�������\" ��������?",
            "��"

        };
        private string[] question2 =
        {
            "��� ������� �����, ������� \n��������� �� ����� ��� ������� \n������ ��������, ����� ������ ���� \n\"���������\" � ����������������.",
            "Hello world",
            "���������� ��� ����� ��������\n������������ ������������, \n�� �� �������� ��� ����� ��������������� \n� ������, ������� ���������� �������.",
            "�����",
            "� 1947 ���� ������� ����� \n� ��������� � ������ ���� � ������, \n����� ����� ������ ������\n����� ��������?",
            "Bug",
            "� 1972 ���� �������� ����\n ���� ���������������� � ���������� ����� \n��������� ������, \n��� ���������� ��� ���������?",
            "C�������� �",
            "������� \n��� ������ ��������� �����\n\n� ����� ���� �������� ������ \n��������������� ���� ����������������?",
            "1954"
        };
        private string[] question3 =
        {
            "Cuphead, Escape from Tarkov,\n Hollow knight, Hearthstone\n ������ ��� ���� ���� �������� �� ���� \n����� ����������������",
            "C#",
            "�� ����� ����� ���� �������� ���� DOOM",
            "C",
            "� ���� ���� ������ ���� ������ ����� � 5 ���,\n� ��� ����� ���������������,\n� ����� �� ��������� ��� ����� ����� ����?",
            "Minecraft",
            "�������� ����������, �������\n��������� ������� ����������� \n������������ ������� � �����?",
            "Ray tracing",
            "��� ��������� ������ ������������ �����,\n� ������ ������ ����� � 1958 ����",
            "������ ��� �����"
        };
        private string[] question4 =
        {
            "����� ���������� ������� \n������ ���������� ���� �#?",
            "Unity",
            "� ����� c# ������������\n������� ��� ������?",
            "������",
            "���� c# ���������� \n���������� ��� �������������?",
            "����������",
            "�������",
            "��� �������������?",
            "�������, ��� ������ ��������� �����\n\n� ����� ���� �������� \n���� ���������������� �#?",
            "1998"
        };
        private string[] question5 =
        {
            "��� ����� IT?",
            "�������������� ����������",
            "��� � �����",
            "��� ����� ������������ �������?",
            "��� ����� DDoS?",
            "�������������� ����� �� ������������",
            "� � � � � � � � � � \n�������� ��������� �����?",
            "�",
            "����� ������� �����?",
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
