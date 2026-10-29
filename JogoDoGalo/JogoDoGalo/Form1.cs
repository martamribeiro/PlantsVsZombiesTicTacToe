namespace JogoDoGalo
{
    public partial class Form1 : Form
    {
        //🌻/🧟
        //variáveis do jogo
        string[] tabuleiro = new string[9];
        string jogadorAtual = "🌻";
        bool jogoTerminado = false;

        public Form1()
        {
            InitializeComponent();

            //Associar os 9 botões ao método EfetuarJogada()
            button0.Click += (s, e) => EfetuarJogada(0, button0);
            button1.Click += (s, e) => EfetuarJogada(1, button1);
            button2.Click += (s, e) => EfetuarJogada(2, button2);
            button3.Click += (s, e) => EfetuarJogada(3, button3);
            button4.Click += (s, e) => EfetuarJogada(4, button4);
            button5.Click += (s, e) => EfetuarJogada(5, button5);
            button6.Click += (s, e) => EfetuarJogada(6, button6);
            button7.Click += (s, e) => EfetuarJogada(7, button7);
            button8.Click += (s, e) => EfetuarJogada(8, button8);
            restart.Click += (s, e) => ReiniciarJogo();

            //Inicializar o tabuleiro
            ReiniciarJogo();
        }

        /*
         EfetuarJogada() vai ser chamado ao clicar em todos os botões
        - verificar se jogo nao terminou
        -- verificar jogador atual
        --- mudar texto do botao para jogador atual
        --- mudar o valor no array do tabuleiro
        --- atualizar de quem é a vez de jogar
        -- VerificarVitoria()
         */
        private void EfetuarJogada(int posicao, Button botao)
        {
            //verificar se jogo terminou
            if (jogoTerminado)
                return;

            //verificar se a posição está ocupada
            if (!string.IsNullOrEmpty(tabuleiro[posicao]))
            {
                return;
            }

            //colocar emoji no botao do tabuleiro
            botao.Text = jogadorAtual;
            tabuleiro[posicao] = jogadorAtual;

            //impedir que o botao seja utilizado
            botao.Enabled = false;

            //Verificar se há vencedor
            VerificarVitoria();

            //se o jogo terminou, nao precisamos de mudar de jogador
            if (jogoTerminado)
                return;

            //verificar se há empate
            bool tabuleiroCheio = true;

            for (int i = 0; i < tabuleiro.Length; i++)
            {
                if (string.IsNullOrEmpty(tabuleiro[i]))
                {
                    tabuleiroCheio = false;
                    break;
                }
            }

            if (tabuleiroCheio)
            {
                jogoTerminado = true;
                label.Text = "Empate!";
                return;
            }

            if (jogadorAtual == "🌻")
            {
                jogadorAtual = "🧟";
                label.Text = "Vez de jogar: 🧟";
            }
            else
            {
                jogadorAtual = "🌻";
                label.Text = "Vez de jogar: 🌻";
            }
        }

        /*
        VerificarVitoria() vai ser chamado no final de cada jogada
        - verificar se existe combinação vencedora no array do tabuleiro
        -- jogoTerminado passa a true
        -- mostrar jogador vencedor
        */
        private void VerificarVitoria()
        {
            int[,] combinaçoes =
            {
                { 0,1,2 },
                { 3,4,5 },
                { 6,7,8 },
                { 0,3,6 },
                { 1,4,7 },
                { 2,5,8 },
                { 0,4,8 },
                { 2,4,6 }
            };

            for (int i = 0; i < combinaçoes.GetLength(0); i++)
            {
                int a = combinaçoes[i, 0];
                int b = combinaçoes[i, 1];
                int c = combinaçoes[i, 2];

                if (!string.IsNullOrEmpty(tabuleiro[a]) &&
                    tabuleiro[a] == tabuleiro[b] &&
                    tabuleiro[b] == tabuleiro[c])
                {
                    jogoTerminado = true;
                    if (jogadorAtual == "🌻")
                    {
                        label.Text = "Vencedor: 🌻";
                    }
                    else
                    {
                        label.Text = "Vencedor: 🧟";
                    }
                    return;
                }
            }
        }

        /*
        ReiniciarJogo() vai ser chamado ao clicar no botao Reiniciar
        - mudar os valores no array tabuleiro para vazios
        - atualizar jogador atual para X
         */
        private void ReiniciarJogo()
        {
            //limpar as posições
            for (int i = 0; i < tabuleiro.Length; i++)
            {
                tabuleiro[i] = "";
            }

            //primeiro jogador vai ser X(🌻)
            jogadorAtual = "🌻";
            label.Text = "Pressiona um botão para jogar!";

            //jogo volta a estar ativo
            jogoTerminado = false;

            //limpar e reativar os botões
            Button[] butoes =
            {
                button0, button1, button2,
                button3, button4, button5,
                button6, button7, button8
            };

            foreach (Button button in butoes)
            {
                button.Text = "";
                button.Enabled = true;
            }

        }
    }
}
