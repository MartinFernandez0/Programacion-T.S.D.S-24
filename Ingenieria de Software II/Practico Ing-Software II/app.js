/*
Clase: Variables -----------------------------------------------------------
*/

var nombre = "Martin"; // Declaración de una variable con el valor "Martin"
let apellido2 = "Fernandez"; // Declaración de una variable con el valor "Fernandez" usando let
const edad2 = "21"; // Declaración de una constante con el valor "21", no se puede modificar

// Mostrar en consola
console.log(nombre); // Imprime "Martin" en la consola
console.log(apellido); // Intenta imprimir una variable no definida (apellido)
console.log(apellido); // Intenta imprimir una variable no definida (apellido)

// DOM
document.write(nombre); // Escribe "Martin" en el documento
let h1 = document.createElement("h1");
h1.textContent = apellido; // Intenta asignar a h1 el valor de una variable no definida (apellido)
document.document.body.appendchild(h1); // Error de sintaxis, debería ser document.body.appendChild(h1)

// Tipos de datos
// PRIMITIVOS
let numer = 10; // Número entero
let stting = "hola"; // Cadena de texto
let booleano = true; // Valor booleano true

// REFERENCIADOS
let objetos = {nombre: "Martin", apellido: "Fernandez"}; // Objeto con propiedades nombre y apellido
let array2 = [1,2,3,4,5,6,7,8, "Martin", true, {} ]; // Array con diversos tipos de elementos

// Variables no definidas
let nulo2 = null; // Variable definida como null
let noDefinido2 = undefined; // Variable definida como undefined

// Operadores Aritméticos
let suma = 5 + 3; // Suma
let resta = 7 - 2; // Resta
let multiplicacion = 4 * 6; // Multiplicación
let division = 10 / 2; // División
let modulo = 10 % 3; // Módulo

// Operadores de Asignación
let x = 10;
let y = 5;
y += 3; // Equivalente a: y = y + 3;

// Operadores de Comparación
console.log(5 == 5); // Verdadero
console.log(5 != 3); // Verdadero
console.log('5' === 5); // Falso (mismo valor y tipo)
console.log(5 !== '5'); // Verdadero (diferente valor o tipo)

// Operadores Lógicos
let a = 5;
let b = 10;
if (a > 0 && b > 0) {
    console.log('Ambos son mayores que 0');
}

let c = 5;
let d = 0;
if (c > 0 || d > 0) {
    console.log('Al menos uno es mayor que 0');
}

let e = true;
let f = !e;
console.log(f); // `f` será `false`

// Operadores de Incremento y Decremento
let nume = 5;
num++; // Incremento en 1
console.log(num);

let num2 = 5;
num2--; // Decremento en 1
console.log(num2);

// Operador Ternario
let edades = 20;
let status = (edad >= 18) ? 'Adulto' : 'Menor';
console.log(status); // Si la edad es mayor o igual a 18, 'Adulto', de lo contrario 'Menor'

// Variables (Repetición de declaración)
var nombre = "Lautaro";
let apellido = "Peresin";
const edad = 19; // No se puede modificar

// Mostrar en consola
console.log(nombre);
console.log(apellido);

// DOM
document.write(nombre);
let h1 = document.createElement('h1');
h1.textContent = apellido;
document.body.appendChild(h1);

// Tipos de datos (Repetición de declaración)
// PRIMITIVOS
let num = 10;
let string = "Cadena de texto";
let boolean = true;
let nulo = null;
// REFERENCIADOS
let objeto = {nombre: "Lautaro", apellido: "Peresin"};
let array = [1,2,3,4,5];
// Variable no definida
let noDefinido = undefined;

console.log(array);

// Funciones ------------------------function = ()=>{}   ()=>{}  ()=>{}  ()=>   ()=>{}-----------
function decirHola(){
    return "Hola!!!";
}

const decirChau = function(){
    return "Chau!!!";
}

const decirHastaLuego = ()=>{
    return "Hasta luego!!!";
}

const sumarNumeros = (a,b) => a + b;

// CALLBACKS
setTimeout(() => {
    console.log("Pasaron 2 segundos");
}, 2000);

const sumarNumerosCallback = (num1, num2, callback)=>{
    const resultado = num1 + num2;
    callback(resultado);
}

sumarNumerosCallback(2, 3, (resultado)=>{
    console.log('El resultado es: ' + resultado);
})

// PROMESAS JAVASCRIPT -------------------------------------------------------------------
// Una promesa es algo dicho que se va a cumplir, sin saber si se va a cumplir o no.

const devolverPromesa = () => {
    return new Promise((resolve,reject)=>{
        setTimeout (()=>{
            resolve("Promesa resuelta");
        }, 2000);
    });
}

devolverPromesa()
.then((respuesta) => {
    console.log(respuesta);
})

// Clase 02/05 ------------------------------------------------------------

// Array
const miArray = [1,2,3,4,5,65,35,2,85,75,32,45,100,200,233,2040,10,20000];
console.log(miArray);

// Agrega elementos al final del array
miArray.push(7);
console.log('PUSH', miArray);

// Elimina el último elemento del array
miArray.pop();
console.log('POP', miArray);

// Elimina el primer elemento del array
miArray.shift();
console.log('SHIFT', miArray);

// Agrega elementos al principio del array
miArray.unshift(1,2,4);
console.log('UNSHIFT', miArray);

// Eliminar elementos del array por índice
miArray.splice(1, 5);
console.log('SPLICE', miArray);

// Retornar una copia de parte del array
const restoSlice = miArray.slice(1,5);
console.log('SLICE', miArray);
console.log('SLICE RESTO', restoSlice);

// Retornar el índice de un elemento en el array
console.log('INDEXOF', miArray.indexOf('Martin')); // Si 'Martin' no existe en el array, retornará -1

// INCLUIDES
console.log('INCLUDES', miArray.includes(5));

// REVERSE
console.log(miArray.reverse());

// SORT - ORDENAR
console.log('SORT a - b', miArray.sort((a,b) => a - b)); // Ordena de menor a mayor
console.log('SORT b - a', miArray.sort((a,b) => b - a)); // Ordena de mayor a menor

// MAP - No transforma el array original, devuelve un nuevo array
const nuevoArraymapeado = miArray.map((item) => item * 2);
console.log('MAP', nuevoArraymapeado);

// FILTER - Filtra elementos basados en una condición
const miArrayFiltrado = miArray.filter((item) => item > 100);
console.log('FILTER', miArrayFiltrado);

// FOREACH - Ejecuta una función para cada elemento del array
miArray.forEach((item) => console.log(item));

// REDUCE - Suma combinada de los elementos en el array
const reduce = miArray.reduce((prev,current) => prev + current);
console.log('REDUCE', reduce);

//Sentencias Switch --------------------------------------------------

var mes = 4;
switch(mes){
    case 1: console.log('Enero')
        break
    case 2: console.log('Febrero')
        break
    case 3: console.log('Marzo')
        break
    case 4: console.log('Abril')
        break
    case 5: console.log('Mayo')
        break
    case 6: console.log('Junio')
        break
    case 7: console.log('Julio')
        break
    case 8: console.log('Agosto')
        break
    case 9: console.log('Septiembre')
        break
    
    default:console.log('Mes no encontrado')
}

//Sentencia FOR - Inicio - Fin/max - Condicion

for(var i=1; i<=10; i++){
    console.log(i);
}

