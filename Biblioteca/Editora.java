package Biblioteca;

import java.util.Scanner;

public class Editora {
    private String nomeSolicitante;
    private String endereco;
    private String email;

    Scanner teclado = new Scanner(System.in);

    public void lerEditora(){
        System.out.println("Digite o nome da editora: ");
        this.setNome(teclado.nextLine());

        System.out.println("Digite o endereço da editora: ");
        this.setEndereco(teclado.nextLine());

        System.out.println("Digite o email da editora: ");
        this.setEmail(teclado.nextLine());

    }

    public String getEmail() {
        return email;
    }

    public void setEmail(String email) {
        this.email = verificaEmail(email);
    }

    public String getEndereco() {
        return endereco;
    }

    public void setEndereco(String endereco) {
        this.endereco = endereco;
    }

    public String getNome() {
        return nomeSolicitante;
    }

    public void setNome(String nome) {
        this.nomeSolicitante = nome;
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
        return "" + nomeSolicitante + "";
    }
}
