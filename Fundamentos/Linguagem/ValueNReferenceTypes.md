# Value and Reference Types
Qualquer tipo no .Net é tratado como referência ou valor

## Heap e Stack

A memória é  dividida em duas partes, ""Heap e Stack""

- Heap armazena os dados
- Stack armazena referências para os dados (endereço da informação)

## Tipos Valor 
Armazenam dados- stack

Ex: Bilt-in, Structs, Enums

int x = 25;

int y = x; Aqui acontece uma copia de valor

## Tipos de referência

Armazendam o endereço do objeto que contém os dados, não os dados em si

- Armazenados no Heap
- Cria uma referência que aponta para a mesma inforação
- Não são independentes
- Quando não utilizados são marcados para exculão(Garbage Collector)

Ex: Classes, Objects, Arrays...
  
