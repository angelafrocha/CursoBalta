# Tipos Primitivos : Built-in types
- Bases Cujo outros tipos (Complexos) irão derivar
- Definir o tipo correto otimiza a execução do programa
- São chamados de **Tipos de Valor**
- Armazenam o Valor e não a referência para um item na memória

## Classificações
- Simples (Simple Types)
- Enumeradores (Enums)
- Estruturas (Structs)
- Tipos Nulos (NUllable Types)

- Cada tipo possui uma capacidade(caso exceda, gera erro)
- A capacidade pré-definida ajuda na otimizção do programa

### Bytes
- O tipo byte pe ultilizado para representar um byte de fato
  - Em diversos casos precisamos da cadeia de bytes de um arquivo(**byte array**)
- O **sbyte permite valores negativos**
**Signed** e **Usigned** : valores com sinal negativo sçao chamados de signed
  
  byte(8-bit): 0 até 255 // sbyte(8-bit): -128 até 127

  ### Números Inteiros
  - tipos:
    - **short/ushort**
    - **int/uint**
    - **long/ulong**

![imgPrimitivos](https://raw.githubusercontent.com/angelafrocha/CursoBalta/master/Fundamentos/Linguagem/TiposPrimitivos/imagens/tipos%20inteiros.png)

### Números reais
- **Float** (Notação F)
- **Double** (mais recomendado)
- **Decimal** (Notação M)
- Assimilção negativa e positica por padrão, dispensando o uso de ***signed/usigned** em seus tipos

![](https://github.com/angelafrocha/CursoBalta/blob/master/Fundamentos/Linguagem/TiposPrimitivos/imagens/fm.png?raw=true)

![](https://github.com/angelafrocha/CursoBalta/blob/master/Fundamentos/Linguagem/TiposPrimitivos/imagens/reais.png?raw=true)

### Boolean (Booleano)
- **true**/**false**
- **bool**(8-bit)

### Char
- Apenas um caractere (Unicode)
- **char**(16-bit): entre aspas simples (')

### String
- Armazena cadeias de caracteres
- "Umas lista de **char**"
- **string**(espaço de mem[oria depende do tamanho da string): entre asás duplas(")

## Valores Padrões
- Todo tipo buit-in já possui um valor padrão
-  Se nenhum valor for informado, seu valor padrao será ultilizado
  - int = 0
  - float = 0
  - bool = false
  - char = '\0'
  - string = ""
