package Biblioteca;

import java.util.Scanner;

public class Autor {
    private String nome;
    private String sobrenome;
    private String email;

    Scanner teclado = new Scanner(System.in);

    public void lerAutor(){
        System.out.println("Digite o primeiro nome do autor: ");
        this.setNome(teclado.nextLine());

        System.out.println("Digite o sobrenome do autor: ");
        this.setSobrenome(teclado.nextLine());

        System.out.println("Digite o email do autor: ");
        this.setEmail(teclado.nextLine());

    }

    public String getNome() {
        return nome;
    }

    public void setNome(String nome) {
        this.nome = verificaChar(nome);
    }

    public String getSobrenome() {
        return sobrenome;
    }

    public void setSobrenome(String sobrenome) {
        this.sobrenome = verificaChar(sobrenome);
    }

    public String getEmail() {
        return email;
    }

    public void setEmail(String email) {
        this.email = verificaEmail(email);
    }

    public String verificaChar(String nome){
        boolean x;
        char a;

        do {
            x = true;

            for (int i = 0; i < nome.length(); i++){
                a = nome.charAt(i);
                int b = a;
                if(b == 32 || b >= 65 && b <= 90 || b >= 97 && b <= 122){
                }else{
                    x = false;
                }
            }
            if(!x){
                System.out.println("Nome inválido\nInforme um nome/sobrenome apenas com letras");
                nome = teclado.nextLine();
            }
        }while(!x);
        return nome;
    }
    public String verificaEmail(String email){
        boolean x;
        char a;

        do {
            x = true;

            for (int i = 0; i < email.length(); i++){
                a = email.charAt(i);
                int b = a;
                if(b == 64){
                    x = false;
                }
            }
            if(x){
                System.out.println("Email inválido\nInforme um email válido");
                email = teclado.nextLine();
            }
        }while(x);
        return email;
    }

    @Override
    public String toString() {
        return "" + nome + " " + sobrenome + "";
    }
}
