import { Injectable } from '@angular/core';
import { Auto } from '../models/auto';  

@Injectable({
  providedIn: 'root'
})
export class AutosService {
  allAutos: Auto [] = [];

  constructor() {}

  getAutos(){
    return this.allAutos = autosDetails.slice(0);
  }

  getAutosById(idBuscado: number){
    return autosDetails.slice(0).find(auto => auto.id = idBuscado);
  }

  getAutosByNombreMarca(nombreMarca: string){
    return autosDetails.slice(0).find(auto => auto.nombre = nombreMarca);
  }
}

const autosDetails = [
  {
    "id": 1,
    "nombre": "Audi",
    "modelos": [
      "A5",
      "A3",
      "A4",
      "A6",
      "S3",
      "S4",
      "TT",
      "A1",
      "TTS",
      "A1 1.4 T",
      "Q7",
      "Q5",
      "Q3",
      "Q2"
    ]
  },
  {
    "id": 2,
    "nombre": "BMW",
    "modelos": [
      "Serie 6",
      "Serie 7",
      "Z4",
      "M6",
      "Serie 1",
      "Serie 3",
      "Serie 5",
      "Serie 8",
      "1800",
      "M",
      "Serie 4",
      "Serie 2",
      "M235",
      "428i",
      "i",
      "1M",
      "M4",
      "M3",
      "M2",
      "X6",
      "X1",
      "X3",
      "X5",
      "X4",
      "X2"
    ]
  },
  {
    "id": 3,
    "nombre": "Chevrolet",
    "modelos": [
      "Alto",
      "Astra",
      "Bel Air",
      "Camaro",
      "Aveo",
      "Cavalier",
      "Celebrity",
      "Citation",
      "Corsa",
      "Chevy",
      "Epica",
      "Esteem",
      "Impala",
      "Malibu",
      "Monza",
      "Optra",
      "Spark",
      "Sprint",
      "Style",
      "Line",
      "Swift",
      "Wagon R+",
      "Sail",
      "Buick",
      "Cruze",
      "39",
      "Cobalt",
      "Sonic",
      "Onix",
      "Beat",
      "Vivant",
      "Blazer 4x2",
      "Captiva",
      "Tahoe",
      "HHR",
      "Courier",
      "Zafira",
      "Blazer",
      "4x4",
      "Grand",
      "Vitara",
      "Grand Blazer",
      "Rodeo",
      "Suburban",
      "Trail",
      "Blazer",
      "Traverse",
      "Orlando",
      "Tracker",
      "Equinox",
      "Jimny",
      "Samurai",
      "Trooper",
      "Vitara",
      "FSR",
      "FVR",
      "FTR",
      "NNR",
      "Cheyenne",
      "C30",
      "3100",
      "Luv",
      "Brigadier",
      "C70",
      "Carry",
      "NHR",
      "NPR",
      "NKR",
      "Super",
      "Brigadier",
      "Super",
      "Carry",
      "Kodiak",
      "NQR",
      "FRR",
      "FVZ",
      "N300",
      "Luv",
      "D-max",
      "DMAX",
      "Super",
      "Carry",
      "NQR",
      "FRR",
      "Carry",
      "CHR",
      "LV",
      "NKR",
      "NPR",
      "Luv",
      "D-max",
      "SSR",
      "Luv Dmax",
      "N300",
      "Apache",
      "C10",
      "C30",
      "Cheyenne",
      "Luv 1.6",
      "Luv 2.2",
      "Luv 2.3",
      "Luv 2.5",
      "Colorado",
      "Luv 2.8",
      "Silverado",
      "Optra",
      "Spark",
      "Corsa",
      "Taxi",
      "Chevette",
      "Chevytaxi",
      "7:24",
      "ChevyVan",
      "ChevyWagon",
      "Super",
      "Carry",
      "N200",
      "N300"
    ]
  },
  {
    "id": 4,
    "nombre": "Citroen",
    "modelos": [
      "Xsara",
      "Picasso",
      "C3",
      "C5",
      "Saxo",
      "Xantia",
      "ZX",
      "C4",
      "C2",
      "Xsara",
      "DS3",
      "DS4",
      "DS5",
      "C-Elysee",
      "Aircross",
      "Aircross",
      "C4",
      "C3",
      "Berlingo",
      "Jumper",
      "Jumpy",
      "Berlingo"
    ]
  },
  {
    "id": 5,
    "nombre": "Daihatsu",
    "modelos": [
      "Charade",
      "Charmant",
      "Sirion",
      "Materia",
      "Terios",
      "F20",
      "Feroza",
      "Rocky",
      "Delta",
      "V126"
    ]
  },
  {
    "id": 6,
    "nombre": "Dodge",
    "modelos": [
      "Coronet",
      "Dart",
      "Demon",
      "D100",
      "Royal",
      "Journey",
      "Caliber",
      "Fargo",
      "Durango",
      "300",
      "600",
      "900",
      "500",
      "Ram",
      "D100",
      "Dakota",
      "Caravan"
    ]
  },
  {
    "id": 7,
    "nombre": "Fiat",
    "modelos": [
      "Zastava",
      "Idea",
      "124",
      "Punto",
      "147",
      "Palio",
      "Polsky",
      "Premio",
      "Siena",
      "Stilo",
      "Tipo",
      "Topolino",
      "Uno",
      "500",
      "Linea",
      "Nuevo",
      "Palio",
      "Argo",
      "Cronos",
      "Adventure",
      "500",
      "X",
      "Fiorino",
      "Furgon",
      "Strada",
      "Idea"
    ]
  },
  {
    "id": 8,
    "nombre": "Ford",
    "modelos": [
      "Fusion",
      "Crown",
      "Victoria",
      "Falcon",
      "Festiva",
      "Fiesta",
      "Focus",
      "Granada",
      "Laser",
      "Mustang",
      "Taurus",
      "Hot",
      "Rod",
      "Escort",
      "Ltd",
      "555E",
      "Chiva",
      "Ecosport",
      "Panel",
      "Edge",
      "Flex",
      "Courier",
      "Escape",
      "Expedition",
      "Explorer",
      "Llanero",
      "Bronco",
      "Piragua",
      "Aeromax",
      "Cargo",
      "815",
      "F350",
      "600",
      "F8000",
      "F 600",
      "F 350[7]",
      "F9000",
      "F-150",
      "Cargo 1019",
      "Cargo 816",
      "F250",
      "Nueva",
      "Ranger",
      "Explorer",
      "F100",
      "F-150",
      "F350",
      "Ranger"
    ]
  }
]
 