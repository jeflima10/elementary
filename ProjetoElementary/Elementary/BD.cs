﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elementary
{
    public class BD
    {
        //Instanciamento dos dicionários
        Dictionary<string,object> listaDeUsuarios = new Dictionary<string, object>();
        Dictionary<string,object> listaDeMedicos = new Dictionary<string,object>();
                
    public BD()
        {
            
        }

       //"Banco de dados" medico
        public BD(Medico pMedico)
        {
            Dictionary<object, string> listaDeMedicos = new Dictionary<object, string>();
            listaDeMedicos.Add(pMedico, pMedico.getEmail());
        }    
        // "Banco de dados" usuario
        public BD(Usuario pUsuario)
        {
            Dictionary<object, string> listaDeUsuarios = new Dictionary<object, string>();
            listaDeUsuarios.Add(pUsuario, pUsuario.getEmail());
        }
        public void gravaMedico(Medico pMedico)
        {            
            listaDeMedicos.Add(pMedico.getEmail(),pMedico);
        }
        public void gravaUsuario(Usuario pUsuario)
        {
            listaDeUsuarios.Add(pUsuario.getEmail(),pUsuario);
        }
    }
    
}
