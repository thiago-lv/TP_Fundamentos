# TP_Fundamentos
UML 
+------------------------------------------+
|              Empresa                      |
+------------------------------------------+
| - private nombre: string                  |
| - private obras: ArrayList                |
| - private obreros: ArrayList	    	    |
| - private jefeObreros: ArrayList	    |
| - private grupos: ArrayList	    	    |
| - private obrasFinalizadas: ArrayList	    |
+------------------------------------------+
| + AgregarObra                             |
| + AgregarJefeObra                         |
| + ActualizarLista                         |
| + AgregarGrupo                            |
| + EliminarGrupo                           |
| + AgregarObrero                           |
| + EliminarObra                            |
| + EliminarObrero		            |
| + EliminarJefeObrero		            |
+------------------------------------------+

                 ▲
                 │
      +----------+----------+
      |                     |
+-------------------+   +-------------------+
|       Obra        |   |      Obrero       |
+-------------------+   +-------------------+
| - nObra: string   |    | - nombre: string  |
| - dniProp: int    |   | - apellido: string|
| - codInterno: int |   | - dni: int        |
| - tipo: string    |   | - nroLegajo: int  |
| - estado: int     |   | - sueldo: int     |
| - jefeObra: JefeObra| | - cargo: string   |
| - costo: int      |   | - codObra: int    |
+-------------------+   +-------------------+
| + ReclutarJObra(): void| + AsignarObra(int):void|
| + EliminarJefeObra():void| + 			|
+-------------------+   +-------------------+

                           ▲
                           │
                +----------+-----------+
                |                      |
       +-------------------+  		+-------------------------------+
       |    JefeDeObra     |  		|   	GrupoObrero               |
       +-------------------+  		+-------------------------------+
       | - bonificacion: int| 		|- integrantesGripo : ArrayList |
       | - grupo : ArrayList| 		|- jefeObra : JefeObrero        |
       | -                  | 		|- codObra: Int 		            |
       | -                  |		|- id: Int 		                  |
       +----------------------------------------------------------------+
       | + AgregarGrupo(): void    |   	|AgregarIntegrante(): void	|
       | +			   |                    |Integrantes(): int		      |
       | +			   |                    |EliminarObrero(): void  	  |
       | +			 |                      |EliminarJefeObrero(): void	|
       | +			   |                    |EncontrarObrero(): bool 	  |
       | +			   |                    |DatosIntegrantes(): void	  |
       | +			   |                    |ActualizarLista(): void 	  |
       | +			   |                    |VerificacionJefe(): void 	|
       +----------------------------------------------------------------+
