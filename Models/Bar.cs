using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bar.Models
{
    public class Bar
    {
        private int idPedido {get;set;}
    
        private int idProtocolo {get;set;}
        private string loginCliente {get;set;}
        private string senhaCliente{get;set;}
        private string nomeCliente{get;set;}

        private string endereco{get;set;}

        private int numeroEndereco{get;set;}

        private string bairroEndereco{get;set;}
        private string itemPedido {get;set;}
        private double valorPedido {get;set;}
        private int quantidadePedido{get;set;}
        private string telefone{get;set;}
        private DateTime dataEntrega{get;set;}

        public int idPedidoPublic 
        {
            get {return idPedido;}
            set {idPedido = value;}
        }
        public int idProtocoloPublic{
            get {return idPedido;}
            set {idPedido = value;}
        }
        public string nomeClientePublic{
            get {return nomeCliente;}
            set {nomeCliente = value;}
        }
        public string loginClientePublic{
            get{return loginCliente;}
            set{loginCliente = value;}
        }
        public string senhaClientePublic
        {
            get {return senhaCliente;}
            set {senhaCliente = value;}
        }
        public string enderecoPublic{
            get{return endereco;}
            set{endereco = value;}
        }
        public int numeroEnderecoPublic{
            get{return numeroEndereco;}
            set{numeroEndereco = value;}
        }
        public string bairroEnderecoPublic{
            get {return bairroEndereco;}
            set {bairroEndereco = value;}
        }
        public string itemPedidoPublic
        {
            get {return itemPedido;}
            set {itemPedido = value;}
        }
        public double valorPedidoPublic{
            get {return valorPedido;}
            set {valorPedido = value;}
        }
           public int quantidadePedidoPublic{
            get {return quantidadePedido;}
            set {quantidadePedido = value;}
        }
           public string telefonePublic{
            get {return telefone;}
            set {telefone = value;}
        }
           public DateTime dataEntregaPublic{
            get {return dataEntrega;}
            set {dataEntrega = value;}
        }
        //Construtor 
      public Bar(int idped, int idProt, string login, string senha, string nome, string ende, int numero, string bairro, string item,
    double valor, int quantidade, string tel, DateTime data)
    {
        idPedido = idped; 
        idProtocolo = idProt;
        loginCliente = login;
        senhaCliente = senha;
        nomeCliente = nome;
        endereco = endereco;
        numeroEndereco = numero;
        bairroEndereco = bairro;
        itemPedido = item;
        valorPedido = valor;
        quantidadePedido = quantidade;
        telefone = tel;
        dataEntrega = data;
    }
    }
   
}