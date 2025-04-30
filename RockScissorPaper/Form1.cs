using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RockScissorPaper
{
    public partial class Form1 : Form
    {
        enum HandRanking // 가위바위보 족보 열거형
        {
            Scissors,   // 0 : 가위
            Rock,       // 1 : 바위
            Paper       // 2 : 보
        }

        enum GameResult // 승부 결과 열거형
        {
            Draw,       // 0 : 무승부
            User,       // 1 : 사용자 승
            Computer    // 2 : 컴퓨터 승
        }

        Random random = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void scissorButton_Click(object sender, EventArgs e)
        {
            int currentUserScore = int.Parse(userScoreTextBox.Text);
            int currentComputerScore = int.Parse(computerScoreTextBox.Text);
            
            HandRanking userHand = HandRanking.Scissors;
            HandRanking computerHand = GetComputerMove();
            GameResult result = GetGameResult(userHand, computerHand);

            if (result == GameResult.User)
            {
                logTextBox.Text += $"사용자 : 가위 | {GetHandString(computerHand)} : 컴퓨터 | 승리\r\n";
                userScoreTextBox.Text = UpdateScore(currentUserScore, result).ToString();
            }
            else if (result == GameResult.Computer)
            {
                logTextBox.Text += $"사용자 : 가위 | {GetHandString(computerHand)} : 컴퓨터 | 패배\r\n";
                computerScoreTextBox.Text = UpdateScore(currentComputerScore, result).ToString();
            }
            else if (result == GameResult.Draw)
            {
                logTextBox.Text += $"사용자 : 가위 | {GetHandString(computerHand)} : 컴퓨터 | 무승부\r\n";
            }
        }

        private void rockButton_Click(object sender, EventArgs e)
        {
            int currentUserScore = int.Parse(userScoreTextBox.Text);
            int currentComputerScore = int.Parse(computerScoreTextBox.Text);

            HandRanking userHand = HandRanking.Rock;
            HandRanking computerHand = GetComputerMove();
            GameResult result = GetGameResult(userHand, computerHand);

            if (result == GameResult.User)
            {
                logTextBox.Text += $"사용자 : 바위 | {GetHandString(computerHand)} : 컴퓨터 | 승리\r\n";
                userScoreTextBox.Text = UpdateScore(currentUserScore, result).ToString();
            }
            else if (result == GameResult.Computer)
            {
                logTextBox.Text += $"사용자 : 바위 | {GetHandString(computerHand)} : 컴퓨터 | 패배\r\n";
                computerScoreTextBox.Text = UpdateScore(currentComputerScore, result).ToString();
            }
            else if (result == GameResult.Draw)
            {
                logTextBox.Text += $"사용자 : 바위 | {GetHandString(computerHand)} : 컴퓨터 | 무승부\r\n";
            }
        }

        private void paperButton_Click(object sender, EventArgs e)
        {
            int currentUserScore = int.Parse(userScoreTextBox.Text);
            int currentComputerScore = int.Parse(computerScoreTextBox.Text);

            HandRanking userHand = HandRanking.Paper;
            HandRanking computerHand = GetComputerMove();
            GameResult result = GetGameResult(userHand, computerHand);

            if (result == GameResult.User)
            {
                logTextBox.Text += $"사용자 : 보 | {GetHandString(computerHand)} : 컴퓨터 | 승리\r\n";
                userScoreTextBox.Text = UpdateScore(currentUserScore, result).ToString();
            }
            else if (result == GameResult.Computer)
            {
                logTextBox.Text += $"사용자 : 보 | {GetHandString(computerHand)} : 컴퓨터 | 패배\r\n";
                computerScoreTextBox.Text = UpdateScore(currentComputerScore, result).ToString();
            }
            else if (result == GameResult.Draw)
            {
                logTextBox.Text += $"사용자 : 보 | {GetHandString(computerHand)} : 컴퓨터 | 무승부\r\n";
            }

        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            userScoreTextBox.Text = "0";
            computerScoreTextBox.Text = "0";
            logTextBox.Text += "모든 점수를 초기화 합니다\r\n";
        }

        private HandRanking GetComputerMove()   // 컴퓨터가 랜덤한 값으로 가위, 바위, 보 중 하나를 반환하는 함수
        {
            switch (random.Next(0, 2))
            {
                case 0:
                    return HandRanking.Scissors; // 열거형에서 가위 값을 반환한다
                case 1:
                    return HandRanking.Rock;     // 열거형에서 바위 값을 반환한다
                case 2:
                    return HandRanking.Paper;    // 열거형에서 보 값을 반환한다
                default:
                    return GetComputerMove();    // 재귀 호출하여 다시 랜덤 값을 반환한다.
            }
        }

        private GameResult GetGameResult(HandRanking user, HandRanking computer)    // Parameter로 제공된 값을 계산하여 게임의 결과를 반환하는 함수
        {
            // 결과 변수 선언 및 초기화
            int result = 0;

            // 승부 계산식
            result = (user - computer + 3) % 3;
            switch (result)
            {
                case 0:
                    return GameResult.Draw;     // 계산 결과가 0일 경우 무승부 값을 반환한다.
                case 1:
                    return GameResult.User;     // 계산 결과가 1일 경우 사용자 승리 값을 반환한다.
                case 2:
                    return GameResult.Computer; // 계산 결과가 2일 경우 컴퓨터 승리 값을 반한다.
                default:
                    return GetGameResult(user, computer);
            }
        }

        private string GetHandString(HandRanking i)
        {
            if (i == HandRanking.Scissors) return "가위";
            else if (i == HandRanking.Rock) return "바위";
            else if (i == HandRanking.Paper) return "보";
            else return "오류";
   
        }

        private int UpdateScore(int currentScore, GameResult result)
        {
            /*
             만약 점수가 3점 이상이라면 즉시 0으로 초기화
             */

            string winner = "";

            if (currentScore > 1)
            {
                winner = GameResult.User == result ? "사용자" : "컴퓨터";
                logTextBox.Text += $"3점 이상 득점 하였음으로 {result}의 점수를 0점으로 초기화 합니다.\r\n";
                return 0;
            }
            else
            {
                return ++currentScore;
            }
        }
        
    }
}
