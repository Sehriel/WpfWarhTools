using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DAOs.DAOInterface;
using DAOBuilder;

namespace ObjWarh.Access_dao
{
/*
    public static class daoInterface
    {
        public static IModel InterfaceDB { get; set; }

        public static void Init()
        {
            InterfaceDB = DAOBuilder.Builder.GetDAO();
        }



        #region INTERFACEDBO

        //Fonction déboguage : utilise un .xml pour charger les talents en DB
        public void DeserializeAndRecord(string pathTalents, string pathCompetences)
        {
            InterfaceDB.DeserializeAndRecord(pathTalents, pathCompetences);
        }

        public void Sauvegarder(Metier.Personnage perso)
        {
            InterfaceDB.Sauvegarder(perso);
        }



        public void ChargerDataSource(List<Metier.Talent> liste)
        {
            foreach (DAOWarhEntities.dto.Talent t in InterfaceDB.QueryTalents())
                liste.Add(t);
        }
        public void ChargerDataSource(List<Metier.Competence> liste)
        {
            foreach (DAOWarhEntities.dto.Competence t in InterfaceDB.QueryCompetences())
                liste.Add(t);
        }
        public void ChargerDataSource(List<Metier.Personnage> liste)
        {
            foreach (DAOWarhEntities.dto.Personnage t in InterfaceDB.QueryPersonnages())
                liste.Add(t);
        }


        public void ChargerDataSource(List<Metier.Talent> listeTalents, List<Metier.Competence> listeComps, List<Metier.Personnage> listePersos)
        {
            ChargerDataSource(listeTalents); 
            ChargerDataSource(listeComps);
            ChargerDataSource(listePersos);
        }
        #endregion
        
    }

    */

}
