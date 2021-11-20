package com.example.demo.controller;

import java.util.ArrayList;
import java.util.List;

import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.PostMapping;
import org.springframework.web.bind.annotation.RequestBody;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.ResponseBody;
import org.springframework.web.bind.annotation.RestController;

import com.example.demo.calculos.CalculaScmol;

@RestController
@RequestMapping("/calcula")
public class ServerController {
	
	List<String> teste = new ArrayList<String>();
//get region	
	@GetMapping
	@RequestMapping("/testeconexao")
	public String ping() {
		return "pong! \nConexão estabelecida com sucesso.";
	}
	
	@GetMapping
	@RequestMapping("/cmol")
	public String calculaCmol() {
		return "Calculo Cmol";
	}
	
	@GetMapping
	@RequestMapping("/fosforo")
	public String calculafosforo() {
		return "Calculo Fosforo";
	}
	
	@GetMapping
	@RequestMapping("/magnesio")
	public List<String> calculamagnesio() {
		
		
		teste.add("teste1");
		teste.add("teste2");
		teste.add("teste");
		
		return teste;
	}
//end get region
	
//post region
	
	@PostMapping("/calculascmol")
	public String calculaSCMol(@RequestBody List<Double> content) {
		
		@SuppressWarnings("unused")
		CalculaScmol calc = new CalculaScmol();
		
		return calc.CalculoScmol(content);
	}
}








