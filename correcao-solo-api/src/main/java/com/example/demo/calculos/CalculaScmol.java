package com.example.demo.calculos;

import java.util.List;

public class CalculaScmol {

	public String CalculoScmol(List<Double> dados) {
		
		double qtdpotassio = dados.get(0); 
		double qtdcalcio = dados.get(1);
		double qtdmagnesio = dados.get(2);
		
		return  Double.toString(qtdcalcio+qtdmagnesio+qtdpotassio);
		
	}
	
}
