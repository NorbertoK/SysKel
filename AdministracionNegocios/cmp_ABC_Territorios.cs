using System.ComponentModel;
using System.Data;
using System.Transactions;

namespace Administración
{
    public partial class CmpABCTerritorios : Component
    {
        public CmpABCTerritorios()
        {
            InitializeComponent();
        }

        public DsTerritorios GetTerritorios()
        {
            var ret = new DsTerritorios();
            paisesTableAdapter1.Fill(ret.Paises);
            provinciasTableAdapter1.Fill(ret.Provincias);
            municipiosTableAdapter1.Fill(ret.Municipios);
            localidadesTableAdapter1.Fill(ret.Localidades);
            callesTableAdapter1.Fill(ret.Calles);
            barriosTableAdapter1.Fill(ret.Barrios);
            return ret;
        }

        public DsCallesLista GetCallesLista()
        {
            var ret = new DsCallesLista();
            callesTableAdapter2.Fill(ret.Calles);
            return ret;
        }

        public DsCallesLista GetCallesListaPorLocalidad(int idLocalidad)
        {
            var ret = new DsCallesLista();
            callesTableAdapter2.FillByIdLocalidad(ret.Calles, idLocalidad);
            return ret;
        }

        public DsLocalidadesLista GetLocalidadesLista()
        {
            var ret = new DsLocalidadesLista();
            localidadesListaTableAdapter1.Fill(ret.LocalidadesLista);
            return ret;
        }

        public DsLocalidades GetLocalidadesConMarca()
        {
            var ret = new DsLocalidades();
            localidadesConMarcaTableAdapter1.Fill(ret.LocalidadesConMarca);
            return ret;
        }
        public DsLocalidades UpdateLocalidadesConMarca(DsLocalidades dsLocalidades)
        {
            using (var ts = new TransactionScope())
            {
                try
                {
                    localidadesConMarcaTableAdapter1.Update(dsLocalidades.LocalidadesConMarca);
                }
                catch
                {
                    ts.Dispose();
                    return null;
                }
                ts.Complete();
                return dsLocalidades;
            }
        }
        public DsBarrios GetBarriosLista()
        {
            var ret = new DsBarrios();
            barriosListaTableAdapter1.Fill(ret.BarriosLista);
            return ret;
        }

        public DsBarrios GetBarriosListaPorLocalidad(int idLocalidad)
        {
            var ret = new DsBarrios();
            barriosListaTableAdapter1.FillByIdLocalidad(ret.BarriosLista, idLocalidad);
            return ret;
        }

        public DsTerritorios UpdateTerritorios(DsTerritorios dsTerritorios)
        {
            using (var ts = new TransactionScope())
            {
                try
                {
                    paisesTableAdapter1.Update(dsTerritorios.Paises.Select("", "",
                                                                           DataViewRowState.Added |
                                                                           DataViewRowState.ModifiedCurrent));
                    provinciasTableAdapter1.Update(dsTerritorios.Provincias.Select("", "",
                                                                                   DataViewRowState.Added |
                                                                                   DataViewRowState.ModifiedCurrent));
                    municipiosTableAdapter1.Update(dsTerritorios.Municipios.Select("", "",
                                                                                   DataViewRowState.Added |
                                                                                   DataViewRowState.ModifiedCurrent));
                    localidadesTableAdapter1.Update(dsTerritorios.Localidades.Select("", "",
                                                                                     DataViewRowState.Added |
                                                                                     DataViewRowState.ModifiedCurrent));
                    callesTableAdapter1.Update(dsTerritorios.Calles);
                    barriosTableAdapter1.Update(dsTerritorios.Barrios);
                    localidadesTableAdapter1.Update(dsTerritorios.Localidades);
                    municipiosTableAdapter1.Update(dsTerritorios.Municipios);
                    provinciasTableAdapter1.Update(dsTerritorios.Provincias);
                    paisesTableAdapter1.Update(dsTerritorios.Paises);
                }
                catch
                {
                    ts.Dispose();
                    return null;
                }
                ts.Complete();
                return dsTerritorios;
            }
        }
    }
}