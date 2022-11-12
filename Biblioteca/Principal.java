package Biblioteca;

import java.util.ArrayList;
import java.util.Scanner;

public class Principal {

	public static void main(String[] args){
        ArrayList<Livros> L = new ArrayList<>();
        char verificador;
        boolean bool = true;
        boolean teste = true;

        Scanner teclado = new Scanner(System.in);

        do {
            int totalDeTitulos = Livros.getTotalDeTitulos();
            int totalDeExemplares = Livros.getTotalDeExemplares();

            System.out.println(totalDeTitulos + " TÍTULOS CADASTRADOS\n" +
                    totalDeExemplares + " EXEMPLARES CADASTRADOS" +
                    "\n\t_________________________" +
                    "\n\t|\t1 - CADASTRAR LIVRO\t|" +
                    "\n\t|\t2 - REMOVER LIVRO\t|" +
                    "\n\t|\t3 - EDITAR LIVRO\t|" +
                    "\n\t|\t4 - PESQUISAR LIVRO\t|" +
                    "\n\t|\t5 - SAIR\t\t|" +
                    "\n\t_________________________");
            verificador = teclado.next().charAt(0);

            switch (verificador) {
                case '1':
                    Livros a = new Livros();

                    a.cadastraLivros();

                    L.add(a);
                    break;

                case '2':
                    if(L.size() > 0) {
                        for (int i = 0; i < L.size(); i++) {
                            System.out.println(i + " - " + L.get(i).getTitulo() + "\n_________________________________\n");
                        }

                        int cont = 0;

                        do {
                            try {
                                System.out.println("Insira o código do livro a ser deletado:");
                                if (cont != 0) {
                                    teclado.next();
                                }
                                int check = teclado.nextInt();
                                Livros.setTotalDeTitulos(totalDeTitulos - 1);
                                Livros.setTotalDeExemplares(totalDeExemplares - L.get(check).getNumeroExemplares());
                                L.remove(check);

                                System.out.println("Livro excluído com êxito!");
                                Livros.enterToContinue();

                                teste = false;
                            } catch (Exception e) {
                                System.out.println("Caracter inválido!");
                                teste = true;
                                cont++;
                            }
                        } while (teste);
                    }else{
                        System.out.println("Tente cadastrar algo antes de excluir!");
                        Livros.enterToContinue();
                    }

                    break;

                case '3':
                    if(L.size() > 0) {
                        for (int i = 0; i < L.size(); i++) {
                            System.out.println(i + " - " + L.get(i).getTitulo() + "\n_________________________________\n");
                        }

                        int cont = 0;

                        do {
                            try {
                                System.out.println("Insira o código do livro a ser editado:");
                                if (cont != 0) {
                                    teclado.next();
                                }
                                int check = teclado.nextInt();
                                Livros.setTotalDeTitulos(totalDeTitulos - 1);
                                Livros.setTotalDeExemplares(totalDeExemplares - L.get(check).getNumeroExemplares());
                                L.remove(check);

                                Livros b = new Livros();

                                b.cadastraLivros();

                                L.add(b);

                                System.out.println("Livro editado com êxito!");
                                Livros.enterToContinue();

                                teste = false;
                            } catch (Exception e) {
                                System.out.println("Caracter inválido!");
                                teste = true;
                                cont++;
                            }
                        } while (teste);
                    }else{
                        System.out.println("Tente cadastrar algo antes de editar!");
                        Livros.enterToContinue();
                    }

                    break;

                case '4':
                    if (L.size() > 0){
                        char variavel;
                        boolean boleano = true;

                        do {
                            System.out.println("\n\tDeseja pesquisar livros pelo:"+
                                    "\n\t_____________________" +
                                    "\n\t|\t1 - TÍTULO\t\t|" +
                                    "\n\t|\t2 - AUTOR\t\t|" +
                                    "\n\t|\t3 - EDITORA\t\t|"+
                                    "\n\t|\t4 - SAIR\t\t|"+
                                    "\n\t_____________________");
                            variavel = teclado.next().charAt(0);

                            switch (variavel){
                                case '1':
                                    Livros buscaTitulo = new Livros();
                                    System.out.println("Digite o título do livro a ser procurado: ");
                                    teclado.nextLine();
                                    buscaTitulo.setTitulo(teclado.nextLine());
                                    for(int j = 0; j < L.size(); j++){
                                        if(buscaTitulo.getTitulo().equals(L.get(j).getTitulo())){
                                            System.out.println(L.get(j).toString());
                                            Livros.enterToContinue();
                                        }else {
                                            System.out.println("Nenhum livro cadastrado com esse título");
                                        }
                                    }
                                    break;

                                case '2':
                                    Livros buscaAutor = new Livros();
                                    Autor autor = new Autor();
                                    System.out.println("Digite o nome do autor do livro a ser procurado: ");
                                    teclado.nextLine();
                                    autor.setNome(teclado.nextLine());
                                    System.out.println("Digite o sobrenome do autor do livro a ser procurado: ");
                                    autor.setSobrenome(teclado.nextLine());
                                    buscaAutor.setAutor(autor);
                                    for(int j = 0; j < L.size(); j++){
                                        if(buscaAutor.getAutor().getNome().equals(L.get(j).getAutor().getNome()) && buscaAutor.getAutor().getSobrenome().equals(L.get(j).getAutor().getSobrenome())){
                                            System.out.println(L.get(j).toString());
                                        }else {
                                            System.out.println("Nenhum livro cadastrado com esse autor");
                                        }
                                    }

                                    Livros.enterToContinue();
                                    break;

                                case '3':
                                    Livros buscaEditora = new Livros();
                                    Editora editora = new Editora();
                                    System.out.println("Digite o nome da editora do livro a ser procurado: ");
                                    teclado.nextLine();
                                    editora.setNome(teclado.nextLine());
                                    buscaEditora.setEditora(editora);
                                    for(int j = 0; j < L.size(); j++){
                                        if(buscaEditora.getEditora().getNome().equals(L.get(j).getEditora().getNome())){
                                            System.out.println(L.get(j).toString());
                                        }else {
                                            System.out.println("Nenhum livro cadastrado com essa editora");
                                        }
                                    }
                                    Livros.enterToContinue();
                                    break;

                                case '4':
                                    boleano = false;

                                    break;

                                default:

                                    break;
                            }
                        }while (boleano);
                    }else{
                        System.out.println("Tente cadastrar algo antes de procurar!");
                        Livros.enterToContinue();
                    }


                    break;

                case '5':
                    bool = false;

                    break;

                default:
                    System.out.println("Entrada invalida, tente novamente!");
                    Livros.enterToContinue();



                    break;
            }
        }while(bool);

        System.out.println("Sistema finalizado!");
    }
}
