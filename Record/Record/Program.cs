using Record;

Player player1 = new Player("ヒノタネ\n","ほのお\n","みず\n",50);

Console.WriteLine("名前:" + player1.name + "タイプ:" + player1.type + "弱点:" + player1.weak + "最大HP:" + player1.hp);

float[] weights = { 10.0f, 15.0f, 20.0f };
for (int i = 0; i < weights.Length; i++)
{
    Console.WriteLine("攻撃パワー" + (i + 1) + ":" + weights[i]);
}


Player player2 = new Player("ミズトカゲ\n", "みず\n", "くさ\n", 50);

Console.WriteLine("名前:" + player2.name + "タイプ:" + player2.type + "弱点:" + player2.weak + "最大HP:" + player2.hp);

for (int i = 0; i < weights.Length; i++)
{
    Console.WriteLine("攻撃パワー" + (i + 1) + ":" + weights[i]);
}


Player player3 = new Player("タネガネ\n", "くさ\n", "ほのお\n", 50);

Console.WriteLine("名前:" + player3.name + "タイプ:" + player3.type + "弱点:" + player3.weak + "最大HP:" + player3.hp);


for (int i = 0; i < weights.Length; i++)
{
    Console.WriteLine("攻撃パワー" + (i + 1) + ":" + weights[i]);
}