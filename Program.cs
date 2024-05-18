using System.Collections.Generic;
Queue<string> pedidos = new Queue<string>();

int opr = -1;
while(opr != 4){
    Console.WriteLine("Seja bem-vindo. Escolha sua operação:\n1 - Listar\n2 - Cadastrar\n3 - Atender\n4 - Sair");
    opr = Convert.ToInt32(Console.ReadLine());
    if(opr == 3) Atender(pedidos);
    if(opr == 2) Cadastrar(pedidos);
    if(opr == 1) Listar(pedidos);    
}
void Listar(Queue<string> fila){
    foreach(string ped in pedidos)
        {Console.WriteLine(ped);}
        Console.WriteLine("--------------------------");}
        
void Cadastrar(Queue<string> fila){
        Console.Write("Digitar nome do boyzinho: ");
        string cliente = Console.ReadLine() ?? "";
        fila.Enqueue(cliente);}

void Atender(Queue<string> fila){
        string cliente = fila.Dequeue();
        Console.WriteLine("Vlw parsero, " + cliente);}

