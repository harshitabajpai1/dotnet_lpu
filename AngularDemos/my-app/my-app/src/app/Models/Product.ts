export class Product{
  prodId:number=0;
  prodName:string="";
  price:number=0;
  expDate:Date=new Date();

  // constructor(){   //default constructor

  // }
  constructor(id:number, name:string, sellPrice:number, expDate:Date){
    this.prodId = id;
    this.prodName = name;
    this.price = sellPrice;
    this.expDate = expDate;

  }
}
