CRUD

\-Create, read, update, delete



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



