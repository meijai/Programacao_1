CRUD

\-Create, read, update, delete

ORM

* object-relational Mapping



XML

* Extensible markup Language



SOAP

* Simple object access protocol





pilares da POO

Abstração - abstrair objetos do mundo real

Encapsulamento - Extrair os atributos do objeto e encapsular-los



passo 1



Entidades (classe)

\-Tutor

\-Animais

\-Atendimento

\-Veterinários Parceiros

\-Procedimentos



passo 2



Atributos das entidades

|Animal<br />- ID<br />- Nome<br />- Espécie<br />- Raça<br />- Peso\_Atendimento<br />- Sexo<br />- Status<br />- Observações|Tutor\_Animal<br />- ID\_Tutor<br />- ID\_Animal|Tutor<br />- ID<br />- Nome<br />- Fone|
|-|-|-|
|Atendimento<br />- ID<br />- ID\_Animal<br />- Data\_Entrada<br />- Data\_Saida<br />- Observações<br />- Peso<br />- ID\_Vet<br />- ID\_Clinica|Atendimento\_Procedimento<br />- ID\_Procedimento<br />- ID\_Atendimento|Procedimento<br />- ID<br />- Descrição<br />- Valor|
|Clinica<br />- ID<br />- Nome<br />- CNPJ|Clinica\_Vet<br />- ID\_Clinica<br />- ID\_Vet|Veterinario<br />- ID<br />- Nome<br />- Telefone|





tudo que esta dentro da classe com () não é um atributo, e sim um método, que são verbos sempre, odo método tem que ser um verbo (fazer comer bater correr)

objetos são ponteiros, quando se referencia uma objeto, e se altera um valor, vai alterar o valor do objeto principal referenciado também



static - 

