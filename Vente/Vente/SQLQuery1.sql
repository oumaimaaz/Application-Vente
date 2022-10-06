CREATE DATABASE Vente

USE Vente

CREATE TABLE Client(CodeCl int PRIMARY KEY,Nom VARCHAR(20),Ville VARCHAR(20))
CREATE TABLE Article(CodeArt int PRIMARY KEY, Designation VARCHAR(20), PU float, QStock int)
CREATE TABLE Commande(NumCom int PRIMARY KEY, DateCom DATE, CodeCl int FOREIGN KEY REFERENCES Client(CodeCl))
CREATE TABLE Detail(NumCom int PRIMARY KEY, CodeArt int FOREIGN KEY REFERENCES Article(CodeArt), Qte int)
