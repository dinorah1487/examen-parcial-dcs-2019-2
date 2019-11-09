const courses = [
  {
    id: 1,
    title: "2124-1254-1234-2564",
    slug: "2124-1254-1234-2564",
    professorId: 1,
    category: "VISA"
  },
  {
    id: 2,
    title: "2124-1254-1234-2565",
    slug: "2124-1254-1234-2565",
    professorId: 2,
    category: "VISA"
  },
  {
    id: 3,
    title: "2124-1254-1234-2566",
    slug: "2124-1254-1234-2566",
    professorId: 3,
    category: "DEBITO"
  },
  {
    id: 4,
    title: "2124-1254-1234-2567",
    slug: "2124-1254-1234-2567",
    professorId: 4,
    category: "DEBITO"
  },
  {
    id: 5,
    title: "2124-1254-1234-2568",
    slug: "2124-1254-1234-2568",
    professorId: 1,
    category: "DEBITO"
  },
  {
    id: 6,
    title: "2124-1254-1234-2569",
    slug: "2124-1254-1234-2569",
    professorId: 5,
    category: "DEBITO"
  },
  {
    id: 7,
    title: "2124-1254-1234-2570",
    slug: "2124-1254-1234-2570",
    professorId: 6,
    category: "DEBITO"
  },
  {
    id: 8,
    title: "2124-1254-1234-2571",
    slug:"2124-1254-1234-2571",
    professorId: 7,
    category: "VISA"
  },
  {
    id: 9,
    title: "2124-1254-1234-2572",
    slug:"2124-1254-1234-2572",
    professorId: 8,
    category: "DEBITO"
  },
  {
    id: 10,
    title: "2124-1254-1234-2573",
    slug: "2124-1254-1234-2573",
    professorId: 5,
    category: "DEBITO"
  },
  {
    id: 11,
    title:  "2124-1254-1234-2574",
    slug: "2124-1254-1234-2574",
    professorId: 8,
    category: "DEBITO"
  },
  {
    id: 12,
    title: "2124-1254-1234-2575",
    slug: "2124-1254-1234-2575",
    professorId: 9,
    category: "DEBITO"
  },
  {
    id: 13,
    title: "2124-1254-1234-2576",
    slug: "2124-1254-1234-2576",
    professorId: 1,
    category: "DEBITO"
  },
  {
    id: 14,
    title: "2124-1254-1234-2577",
    slug:"2124-1254-1234-2577",
    professorId: 10,
    category: "DEBITO"
  },
  {
    id: 15,
    title: "2124-1254-1234-2578",
    slug:  "2124-1254-1234-2578",
    professorId: 11,
    category: "DEBITO"
  },
  {
    id: 16,
    title:  "2124-1254-1234-2579",
    slug:  "2124-1254-1234-2579",
    professorId: 12,
    category: "VISA"
  }
];

const professors = [
  { id: 1, name: "BCP" },
  { id: 2, name: "Interbank" },
  { id: 3, name: "Banco Pichincha" },
  { id: 4, name: "Banco nacional" },
  { id: 5, name: "Banco Central Reserva" },
  { id: 6, name: "Banco Continental" },
  { id: 7, name: "Banco Scotiabank" },
  { id: 8, name: "Banco Financiero" },
  { id: 9, name: "Caja Municipal Saire" },
  { id: 10, name: "Caja Municipal de Piura" },
  { id: 11, name: "Caja Municipal de Rio" },
  { id: 12, name: "Banco de Chipre" },
];

const newCourse = {
  id: null,
  title: "",
  professorId: null,
  category: ""
};

// Using CommonJS style export so we can consume via Node (without using Babel-node)
module.exports = {
  newCourse,
  courses,
  professors
};
