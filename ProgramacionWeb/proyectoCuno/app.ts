"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
exports.Persona = void 0;
console.log("hola soy el pirmer archivos ts");
console.error("hola soy el pirmer archivos ts");
console.dir("hola soy el pirmer archivos ts");
var foo = 123;
if (true) {
  var foo = 456;
  console.log("var foo : " + foo);
  var nombre = "alex";
  var isDone = false;
  var decimal = 45;
  var name_1 = "Robert";
  var sentencia = "Hello, my name is ".concat(name_1, " ");
  var sentenciaDos = "Hello, my name is " + name_1;
  var sentenciaTres = "Hello, my name is " + name_1;
}
var Persona = /** @class */ (function () {
  function Persona(nombre, apellido, edad, dni) {
    this.nombre;
    nombre;
    this.apellido;
    apellido;
    this.edad;
    edad;
    this.dni;
    dni;
  }
  Persona.prototype.camina = function () {
    console.log("estoy caminando");
  };
  return Persona;
})();
exports.Persona = Persona;
