/*
 * Created by SharpDevelop.
 * User: Thiago
 * Date: 16/10/2024
 * Time: 21:59
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections;
using System.Collections.Generic;

namespace TP_INTEGRADOR
{
	class Program
	{
		public static void Main(string[] args)
		{
			
			// datos ya cargados : 
			Empresa em1 = new Empresa();
			// Grupos
			GrupoObrero gr1 = new GrupoObrero(1,1);
			GrupoObrero gr2 = new GrupoObrero(2,2);
			GrupoObrero gr3 = new GrupoObrero(3,3);
			GrupoObrero gr4 = new GrupoObrero(4,4);
			GrupoObrero gr5 = new GrupoObrero(5,5);
			GrupoObrero gr6 = new GrupoObrero(6,6);
			GrupoObrero gr7 = new GrupoObrero(7,7);
			GrupoObrero gr8 = new GrupoObrero(8,8);
			
			// Obreros
			Obrero ob1 = new Obrero("Raul", "Magallan", "Constructor", 42452, 24134, 2324, 1);
			Obrero ob2 = new Obrero("Sofia", "Lopez", "Electricista", 23456, 23456, 3000, 2);
			Obrero ob3 = new Obrero("Carlos", "Perez", "Plomero", 34567, 45678, 2900, 3);
			Obrero ob4 = new Obrero("Ana", "Gonzalez", "Carpintero", 45678, 56789, 3200, 4);
			Obrero ob5 = new Obrero("Luis", "Fernandez", "Pintor", 56789, 67890, 2800, 5);
			Obrero ob6 = new Obrero("Marta", "Jimenez", "Mecánico", 67890, 78901, 3100, 6);
			Obrero ob7 = new Obrero("Jorge", "Ramirez", "Obrero de construcción", 78901, 89012, 2500, 7);
			Obrero ob8 = new Obrero("Lucia", "Sanchez", "Jardinero", 89012, 90123, 2700, 8);
			Obrero ob9 = new Obrero("Pedro", "Castillo", "Soldador", 90123, 12345, 3300, 1); // Grupo 1
			Obrero ob10 = new Obrero("Clara", "Martinez", "Ayudante", 12345, 23457, 2400, 2); // Grupo 2
			Obrero ob11 = new Obrero("Felipe", "Nunez", "Albañil", 11111, 11111, 2500, 3);
			Obrero ob12 = new Obrero("Isabel", "Cruz", "Electricista", 22222, 22222, 3100, 4);
			Obrero ob13 = new Obrero("Victor", "Martinez", "Fontanero", 33333, 33333, 2900, 5);
			Obrero ob14 = new Obrero("Nora", "Alvarez", "Carpintera", 44444, 44444, 3200, 6);
			Obrero ob15 = new Obrero("Raúl", "Gonzales", "Pintor", 55555, 55555, 2800, 7);
			Obrero ob16 = new Obrero("Elena", "Torres", "Mecánica", 66666, 66666, 3000, 8);
			Obrero ob17 = new Obrero("Javier", "Salazar", "Operador", 77777, 77777, 3100, 1);
			Obrero ob18 = new Obrero("Laura", "Rivas", "Soldadora", 88888, 88888, 3400, 2);
			Obrero ob19 = new Obrero("Andrés", "Valencia", "Conductor", 99999, 99999, 3200, 3);
			Obrero ob20 = new Obrero("Patricia", "López", "Administrativa", 10101, 10101, 2700, 4);
			// Agregando los obreros 
			// Agregar obreros a los grupos
			gr1.AgregarIntegrante(ob1);
			gr1.AgregarIntegrante(ob2);
			gr1.AgregarIntegrante(ob3);
			gr1.AgregarIntegrante(ob4);
			gr1.AgregarIntegrante(ob5);
			gr1.AgregarIntegrante(ob6);
			gr1.AgregarIntegrante(ob7);
			gr1.AgregarIntegrante(ob8);
            // Agregando obreros a la empresa:
            em1.AgregarObrero(ob1);
            em1.AgregarObrero(ob2);
            em1.AgregarObrero(ob3);
            em1.AgregarObrero(ob4);
            em1.AgregarObrero(ob5);
            em1.AgregarObrero(ob6);
            em1.AgregarObrero(ob7);
            em1.AgregarObrero(ob8);
            em1.AgregarObrero(ob9);
            em1.AgregarObrero(ob10);
            em1.AgregarObrero(ob11);
            em1.AgregarObrero(ob12);
            em1.AgregarObrero(ob13);
            em1.AgregarObrero(ob14);
            em1.AgregarObrero(ob15);
            em1.AgregarObrero(ob16);
            em1.AgregarObrero(ob17);
            em1.AgregarObrero(ob18);
            em1.AgregarObrero(ob19);
            em1.AgregarObrero(ob20);
            gr2.AgregarIntegrante(ob9);
			gr2.AgregarIntegrante(ob10);
			gr3.AgregarIntegrante(ob11);
			gr3.AgregarIntegrante(ob12);
			gr4.AgregarIntegrante(ob13);
			gr4.AgregarIntegrante(ob14);
			gr5.AgregarIntegrante(ob15);
			gr5.AgregarIntegrante(ob16);
			gr6.AgregarIntegrante(ob17);
			gr6.AgregarIntegrante(ob18);
			gr7.AgregarIntegrante(ob19);
			gr8.AgregarIntegrante(ob20);
			// Agregando los grupos a las empresas
			em1.AgregarGrupo(gr1);
			em1.AgregarGrupo(gr2);
			em1.AgregarGrupo(gr3);
			em1.AgregarGrupo(gr4);
			em1.AgregarGrupo(gr5);
			em1.AgregarGrupo(gr6);
			em1.AgregarGrupo(gr7);
			em1.AgregarGrupo(gr8);
			// Obras 
			Obra obra1 = new Obra("Obra 1", "Construcción", 20, 50000, 12345678, 1);
			Obra obra2 = new Obra("Obra 2", "Remodelación", 50, 25000, 23456789, 2);
            Obra obra3 = new Obra("Obra 3", "Ejecución", 10, 75000, 34567890, 3);
            Obra obra4 = new Obra("Obra 4", "Remodelación", 90, 40000, 45678901, 4);
            Obra obra5 = new Obra("Obra 5", "Construcción", 60, 60000, 56789012, 5);
            Obra obra6 = new Obra("Obra 6", "Construcción", 30, 55000, 67890123, 6);
            Obra obra7 = new Obra("Obra 7", "Ejecución", 0, 45000, 78901234, 7);
            Obra obra8 = new Obra("Obra 8", "Remodelación", 75, 30000, 89012345, 8);
            Obra obra9 = new Obra("Obra 9", "Construcción", 100, 80000, 90123456, 9);
            Obra obra10 = new Obra("Obra 10", "Remodelación", 100, 35000, 12309876, 10);
			Obra obra11 = new Obra("Obra 4", "Finalizada", 100, 30000, 45678901, 4);
			Obra obra12 = new Obra("Obra 5", "Finalizada", 100, 60000, 56789012, 5);
            em1.AgregarObra(obra1);
            em1.AgregarObra(obra2);
            em1.AgregarObra(obra3);
            em1.AgregarObra(obra4);
            em1.AgregarObra(obra5);
            em1.AgregarObra(obra6);
            em1.AgregarObra(obra7);
            em1.AgregarObra(obra8);
            em1.AgregarObra(obra9);
            em1.AgregarObra(obra10);
			em1.AgregarObra(obra11);
			em1.AgregarObra(obra12);
            JefeObrero jf2 = new JefeObrero("Ana", "Martínez", "Jefe de área", 23456789, 2, 60000, 1500, 2, 102);
            JefeObrero jf7 = new JefeObrero("Roberto", "Pérez", "Supervisor", 78901234, 7, 52000, 900, 7, 107);
            gr2.JEFEOBREROGRUPO = jf2;
            gr7.JEFEOBREROGRUPO = jf7;
            em1.AgregarOJefeObrero(jf7);
            em1.AgregarOJefeObrero(jf2);
            Console.WriteLine("Hello World!");
			// Funcion 1
			//Contratar un obrero nuevo (se agrega a la empresa y a un grupo


			//			FUNCION 1 RECLUTAR OBRERO
			//			Console.WriteLine(gr1.Integrantes());
			//			
			//			Console.WriteLine(gr1.Integrantes());
			//			int i = 0;
			//			while (i < 2){
			//				Obrero nuevo = reclutarObrero(em1);
			//				em1.AgregarObrero(nuevo);
			//				gr1.AgregarIntegrante(nuevo.Nombre,nuevo.Apellido);
			//				i++;
			//			}
			//			Console.WriteLine(gr1.Integrantes());
			//			gr1.DatosIntegrantes();
			//			// Funcion 2
			//			// Eliminar un obrero (se elimina de la empresa y de su grupo)
			//			string n = EliminarObrero(em1);
			//			Console.WriteLine(n);

			// Contratar a un jefe de obra (se asigna a una obra existente) y se le asocia un grupo de
			//			obreros libre. Si no existe ningún grupo libre se debe levantar una excepción que indique lo sucedido.
			//reclutarJefObrero(em1);
			int condicionMenu = 0;
			while (condicionMenu == 0)
			{
				Console.Clear();
				Console.WriteLine("Menu Principal");
				Console.WriteLine("1. Contratar un nuevo obrero");
				Console.WriteLine("2. Eliminar un obrero");
				Console.WriteLine("3. Contratar un jefe de obra");
				Console.WriteLine("4. Ir a submenú");
                Console.WriteLine("5. Dar de baja un JEFE DE OBRA");
                Console.WriteLine("0. Salir del programa");
				Console.Write("Seleccione una opción: ");
				int opcionMenu = int.Parse(Console.ReadLine());

				switch (opcionMenu)
				{
					case 1:
						Obrero nuevo = reclutarObrero(em1);
						em1.AgregarObrero(nuevo);
						int numeroGrupoAAgregar = nuevo.NGrupo;
						foreach (GrupoObrero x in em1.GRUPOS) {
							if(x.ID == numeroGrupoAAgregar){
								x.AgregarIntegrante(nuevo);
							}
						}
						Console.ReadKey(true);
						break;
					case 2:
						EliminarObrero(em1, gr1, gr2, gr3, gr4, gr5, gr6, gr7, gr8);
						Console.WriteLine("Obrero ELIMINADO! PRESIONE CUALQUIER BOTON PARA CONTINUAR ");
						Console.ReadKey(true);
						break;
					case 3:
						reclutarJefObrero(em1);
						Console.ReadKey(true);
						break;
					case 4:
						Console.WriteLine("Dirijiendose al submenu de Impresion");
						bool salir = false;
						while (!salir)
						{
							ArrayList listaObreros = em1.OBREROS;
							ArrayList listaObras = em1.OBRAS;
							Console.WriteLine("\n--- Submenú de Impresión ---");
							Console.WriteLine("1. Listado de Obreros");
							Console.WriteLine("2. Obras en Ejecución");
							Console.WriteLine("3. Obras Finalizadas");
							Console.WriteLine("4. Listado de Jefes");
							Console.WriteLine("5. Porcentaje de Obras de Remodelación sin Finalizar");
							Console.WriteLine("0. VOLVER AL MENU ANTERIOR");
							Console.Write("Seleccione una opción: ");
							string opcion = Console.ReadLine();
							switch (opcion)
							{
								case "1":
									Console.WriteLine("\nListado de Obreros:");
									foreach (Obrero x in listaObreros)
									{
										Console.WriteLine("NOMBRE: " + x.Nombre + ", APELLIDO: " + x.Apellido + ", DNI: " + x.Dni.ToString() + ", CARGO: " + x.Cargo + ", SUELDO: " + x.Sueldo.ToString() +", NUMERO LEGAJO: " + x.NroLegajo + " y NUMERO DE GRUPO: " + x.NGrupo);
									}
									break;

								case "2":
									Console.WriteLine("\nObras en Ejecución:");
									foreach (Obra x in listaObras)
									{
										if (x.Tipo == "Ejecución")
										{
											Console.WriteLine("Nombre de la Obra: " + x.NObra + ", JEFE DE LA OBRA: " + x.JObra + ", ESTADO DE AVANCE: " + x.EstAvance.ToString() + ", DNI DEL PROPIETARIO: " + x.DniPropietario);
										}
									}
									break;

								case "3":
									Console.WriteLine("\nObras Finalizadas:");
									foreach (Obra x in listaObras)
									{
										if (x.Tipo == "Finalizada")
										{
											Console.WriteLine("Nombre de la Obra: " + x.NObra + ", JEFE DE LA OBRA: " + x.JObra + ", ESTADO DE AVANCE: " + x.EstAvance.ToString() + ", DNI DEL PROPIETARIO: " + x.DniPropietario);
										}
									}
									break;

								case "4":
									Console.WriteLine("\nListado de Jefes:");
									ArrayList listaJefes = em1.JEFEOBREROS;
									foreach (JefeObrero x in listaJefes)
									{
										Console.WriteLine("NOMBRE: " + x.Nombre + ", Apellido: " + x.Apellido + ", GRUPO A CARGO: " + x.NUMEROGRUPO.ToString() + ", NUMERO DE LEGAJO: " + x.NroLegajo.ToString());

									}
									break;

								case "5":
									Console.WriteLine("\nPorcentaje de Obras de Remodelación sin Finalizar:");
									int obrasFinalizadas = 0;
									int obrasRemodelacion = 0;
									foreach (Obra x in em1.OBRAS)
									{
										if (x.Tipo == "Remodelación" & x.EstAvance == 100)
										{
											obrasFinalizadas++;
											obrasRemodelacion++;
										}
										else if (x.Tipo == "Remodelación")
										{
											obrasRemodelacion++;
										}
									}
									Console.WriteLine("Obras Finalizadas: " + obrasFinalizadas.ToString() + " y obras Remodeladas: " + obrasRemodelacion.ToString());
									double porcentaje = ((double)obrasFinalizadas / obrasRemodelacion) * 100;
									Console.WriteLine("El porcentaje de obras sin finalizar es " + porcentaje + "%");
									break;
									Console.WriteLine();
								case "0":
									Console.WriteLine("Saliendo del submenú...");
									salir = true;
									break;

								default:
									Console.WriteLine("Opción inválida. Por favor, intente nuevamente.");
									break;
							}
						}
						break;
					case 5:
						Console.WriteLine("Elegiste la opcion eliminar un jefe");
						Console.WriteLine("Estos son los JEFES QUE SE ENCUENTRAN:");
						bool condicion = true;
						ArrayList ListaJefes = em1.JEFEOBREROS; 
						ArrayList ListaGrupos = em1.GRUPOS;
						ArrayList ListaObras = em1.OBRAS;
						string nombreJefeAEliminar = "x";
                        foreach (JefeObrero x in ListaJefes)
                        {
						Console.WriteLine("Nombre: " + x.Nombre + " , Apellido: " + x.Apellido + ", \nDNI: " + x.Dni.ToString() + ", Numero de Legajo: " + x.NroLegajo.ToString() + " y Grupo que dirije: " + x.NUMEROGRUPO.ToString());   
                        }
						Console.WriteLine("Inserte su NUMERO DE Legajo para Eliminarlo:");
						int nroLegajoEliminar = int.Parse(Console.ReadLine());
						foreach (JefeObrero b in ListaJefes) {
							if (b.NroLegajo == nroLegajoEliminar)
							{
								nombreJefeAEliminar = b.Nombre;
								em1.EliminarJefeObrero(b);
								Console.WriteLine("Jefe Eliminado de la Empresa");
								foreach (GrupoObrero c in ListaGrupos)
								{
									if (c.JEFEOBREROGRUPO.NroLegajo == nroLegajoEliminar)
									{
										c.EliminarJefeObrero(b);
									}
								};
								foreach (Obra d in ListaObras)
								{
									if (d.JObra == nombreJefeAEliminar)
									{
										d.EliminarJefeObra(nombreJefeAEliminar);
									}
								}
								condicion = false;
							}
						};
                        if (condicion == true)
                        {
							Console.WriteLine("No se encontro al JefeObrero intentelo denuevo.");
                        }
                        break;
					case 0:
						Console.WriteLine("Saliendo del programa...");
						condicionMenu++;
						break;
					default:
						Console.WriteLine("Opción no válida. Intente nuevamente.");
						break;
				}
			}
            Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
		
		// Funciones 
		public static Obrero reclutarObrero(Empresa x){
			Console.WriteLine("Indique el NOMBRE del obrero:");
			string nomObrero = Console.ReadLine();
			Console.WriteLine("Indique el APELLIDO del obrero:");
			string apeObrero = Console.ReadLine();
			Console.WriteLine("Indique el CARGO del obrero:");
			string cargoObrero = Console.ReadLine();
			Console.WriteLine("Indique el NUMERO DE LEGAJO del obrero:");
			int nroLegajoObrero = int.Parse(Console.ReadLine());
			Console.WriteLine("Indique el DNI del obrero:");
			int dniObrero = int.Parse(Console.ReadLine());
			Console.WriteLine("Indique el SUELDO del obrero:");
			int sueldoObrero = int.Parse(Console.ReadLine());
			Console.WriteLine("Indique al GRUPO QUE SE LE ASIGNARA del obrero:");
			int numGrupo = int.Parse(Console.ReadLine());
			Console.WriteLine("-------------------------------------------------------------");
			Obrero nuevoObrero = new Obrero(nomObrero,apeObrero,cargoObrero,dniObrero,nroLegajoObrero,sueldoObrero,numGrupo);
			return nuevoObrero;
			}
		public static string EliminarObrero(Empresa x,GrupoObrero gro1,GrupoObrero gro2,GrupoObrero gro3,GrupoObrero gro4,GrupoObrero gro5,GrupoObrero gro6,GrupoObrero gro7,GrupoObrero gro8){
			ArrayList listaObreros = x.OBREROS;
			string resultado = "Obrero no ELIMINADO!";
			Console.WriteLine("Estos son los obreros:");
			foreach (Obrero element in listaObreros) {
				Console.WriteLine("NOMBRE:"+ element.Nombre + " APELLIDO:" + element.Apellido);
				
			}
			Console.WriteLine("Indique el nombre del obrero a ELIMINAR:");
			string nomEliminar = Console.ReadLine();
			Console.WriteLine("Indique el apellido del obrero:");
			string apeEliminar= Console.ReadLine();
			string[] datosObrerosEliminar = {nomEliminar,apeEliminar};
			ArrayList copia = new ArrayList(listaObreros);
			foreach (Obrero element in copia) {
				if(element.Nombre == nomEliminar && element.Apellido == apeEliminar){
					listaObreros.Remove(element);
					int numGrupo = element.NGrupo;
					switch (numGrupo){
					case 1:
						gro1.EliminarObrero(element);
						break;
					case 2:
						gro2.EliminarObrero(element);
						break;
					case 3:
						gro3.EliminarObrero(element);
						break;
					case 4:
						gro4.EliminarObrero(element);
						break;
					case 5:
						gro5.EliminarObrero(element);
						break;
					case 6:
						gro6.EliminarObrero(element);
						break;
					case 7:
						gro7.EliminarObrero(element);
						break;
					case 8:
						gro8.EliminarObrero(element);
						break;
					}
					x.ActualizarLista(listaObreros);
					return "Obrero eliminado con exito";
				}
			}
			return resultado;
		}
		public static void reclutarJefObrero(Empresa x){
			Console.WriteLine("Indique el NOMBRE del  JEFE obrero:");
			string nomObrero = Console.ReadLine();
			Console.WriteLine("Indique el APELLIDO del JEFE obrero:");
			string apeObrero = Console.ReadLine();
			string cargoObrero = "Jefe de Obra";
				Console.WriteLine("Indique el NUMERO DE LEGAJO del JEFE obrero:");
				int nroLegajoObrero = int.Parse(Console.ReadLine());
				Console.WriteLine("Indique el DNI del JEFE obrero:");
				int dniObrero = int.Parse(Console.ReadLine());
				Console.WriteLine("Indique el SUELDO del JEFE obrero:");
				int sueldoObrero = int.Parse(Console.ReadLine());
				Console.WriteLine("Indique la BONIFICACION que recibira: ");
				int bonificacion = int.Parse(Console.ReadLine());
				int num = AsignarGrupo(x);
				int codObra = AsignarObra(x);
			try
			{
                if (num >= 1)
                {
                    Console.WriteLine("Grupo ASIGNADO PARA EL JEFE OBRERO!");
					Console.WriteLine(num);
                    JefeObrero jf = new JefeObrero(nomObrero, apeObrero, cargoObrero, nroLegajoObrero, dniObrero, sueldoObrero, bonificacion, num, codObra);
                    x.AgregarObrero(jf);
                    foreach (GrupoObrero c in x.GRUPOS)
                    {
                        if (num > 0 && num == c.ID)
                        {
							x.AgregarOJefeObrero(jf);
							c.JEFEOBREROGRUPO = jf;
                            jf.AgregarGrupo(c);
                            Console.WriteLine("Obrero RECLUTADO! PRESIONE CUALQUIER BOTON PARA CONTINUAR ");
                        }
                    }
                    foreach (Obra b in x.OBRAS)
                    {
                        if (b.ID == codObra)
                        {
                            b.ReclutarJObra(jf);
                        }
                    }
                }
                else
                {
                    throw new NoHayGruposLibresException("No hay GRUPOS DISPONIBLES PARA ASIGNARLE AL JEFE OBRERO");
                }
            }
			catch (NoHayGruposLibresException e)
			{
				Console.WriteLine("Error: " + e.motivo);
			}
		}
		public static int AsignarGrupo(Empresa b){
			int grupo = 0;
			ArrayList gruposObreros = b.GRUPOS;
			foreach (GrupoObrero element in gruposObreros) {
				bool existenciaJefe = element.VerificacionJefe();
				if (existenciaJefe == false) {
					return element.ID;
				}
            }

			return grupo;
		}
		public static int AsignarObra(Empresa b) {
			int numero = 0;
			ArrayList listaObras = b.OBRAS;
            foreach (Obra x in listaObras)
            {
                if(x.JObra == "Ninguno")
				{
					numero = x.ID;
					return numero;
				}
            }
			return numero;
        }
		public static void ModificarEstadoAvance(Empresa x) {
			int nuevoEstadoAvance = 0;
			int verificacion = 0;
			// MODIFICAR ESTADO DE AVANCE
			Console.WriteLine("Indique el NUMERO DE OBRA que quiere modificar por su estado de avance: ");
            foreach (Obra b in x.OBRAS)
            {
				Console.WriteLine("NOMBRE de OBRA: " + b.NObra + " a CARGO DE: " + b.JObra + " ESTADO DE AVANCE: " + b.EstAvance.ToString() + " , NUMERO DE OBRA ES: " + b.ID.ToString());

            }
			int identificarObra = int.Parse(Console.ReadLine());
            foreach (Obra b in x.OBRAS)
            {
				if (identificarObra == b.ID) {
					Console.WriteLine("Obra identificada!");
					Console.WriteLine("Indique el estado de avance de la obra (ESCRIBA EL NUMERO SIN EL %)");
					nuevoEstadoAvance = int.Parse(Console.ReadLine());
					b.EstAvance = nuevoEstadoAvance;
					verificacion = 1;
					break;
				}
            }
			if (verificacion == 0) {
				throw new ObraNoEncontrada("La obra no fue encontrada.");
			}
			// Encontrar estados de avance del 100%
			foreach (Obra b in x.OBRAS) {
				if (b.EstAvance == 100) {
                    b.Tipo = "Finalizada";
                    x.EliminarObra(b);
					x.OBRASFINALIZADAS.Add(b);
				}
			}
        }
	}
	public class Empresa{
		private ArrayList obreros = new ArrayList();
        private ArrayList jefeObreros = new ArrayList();
        private ArrayList obras = new ArrayList();
		private ArrayList grupos = new ArrayList(8);
		private ArrayList obrasFinalizadas = new ArrayList();
		
		// Properties
		public ArrayList OBREROS{
			get{
				return obreros;
			}
			set { this.obreros = value; }
		}
		public ArrayList OBRAS{
			get{
				return obras;
			}
			set { this.obras = value; }
		}
		public ArrayList GRUPOS{
			get{
				return grupos;
			}
			set { this.grupos = value; }
		}
		public ArrayList JEFEOBREROS
		{
			get { return jefeObreros; }
			set { this.jefeObreros = value; }
		}
		public ArrayList OBRASFINALIZADAS {
			get { return obrasFinalizadas; }
			set { this.obrasFinalizadas = value; }
		}
		// Funciones
		public void ActualizarLista(ArrayList x){
			obreros = new ArrayList(x);
		}
		public void AgregarObrero(Obrero x){
			obreros.Add(x);
		}
        public void AgregarOJefeObrero(JefeObrero x)
        {
            jefeObreros.Add(x);
        }
        public void AgregarGrupo(GrupoObrero x){
			grupos.Add(x);
		}
		public void AgregarObra(Obra x) { 
			obras.Add(x);
		}
		public void EliminarObrero(Obrero x) { 
			obreros.Remove(x);
		}
		public void EliminarObra(Obra x) { 
			obras.Remove(x);
		}
		public void EliminarGrupo(GrupoObrero x) { 
			grupos.Remove(x);
		}
		public void EliminarJefeObrero(JefeObrero x) { 
			jefeObreros.Remove(x);
		}
	}
	
	public class Obra{
		private string nObra,tipo,jObra;
		private int estAvance,costo,dniPropietario,id;
		
		// Propiedades
		public string NObra{
			get{
				return nObra;
			}
			set{ this.nObra = value; }
			}
		public string Tipo{
			get{
				return tipo;
			}
			set{ this.tipo = value; }
			}
		public string JObra{
			get{
				return jObra;
			}
			set { this.jObra = value; }
			}
		public int EstAvance{
			get{
				return estAvance;
			}
			set { this.estAvance = value; }
			}
		public int Costo{
			get {
				return costo;
			}
			set { this.costo = value; }
		}
		public int DniPropietario{
			get {
				return dniPropietario;
			}
				set { this.dniPropietario = value; }	
			}
		public int ID {
			get{
				return id;
			}
			set { this.id = value; }
			
		}
		
		// Constructor
		public Obra(string nombreObra,string tipoObra,int estadoAvance, int costoObra,int dniPropietarioObra,int idObra){
			this.nObra = nombreObra;
			this.tipo = tipoObra;
			this.estAvance = estadoAvance;
			this.costo = costoObra;
			this.dniPropietario = dniPropietarioObra;
			this.id = idObra;
			this.jObra = "No Asignado";
		}
		public void ReclutarJObra(JefeObrero x){
			jObra = x.Nombre;
		}
        public void EliminarJefeObra(string x)
        {
				jObra = "SIN ASIGNAR";
        }
        public void imprimir(){
			Console.WriteLine(costo);
		}
		
		
	}
	
	public class Obrero{
		private string nombre,apellido,cargo;
		private int dni,nroLegajo,sueldo,nGrupo;
		// Propiedades
		public string Nombre{
			get { return nombre; }
			set { this.nombre = value; }
		}
        public string Apellido
        {
            get { return apellido; }
            set { this.apellido = value; }
        }

        public string Cargo
        {
            get { return cargo; }
            set { this.cargo = value; }
        }

        public int NroLegajo
        {
            get { return nroLegajo; }
            set { this.nroLegajo = value; }
        }

        public int Dni
        {
            get { return dni; }
            set { this.dni = value; }
        }

        public int Sueldo
        {
            get { return sueldo; }
            set { this.sueldo = value; }
        }
		public int NGrupo
		{
			get { return nGrupo; }
			set { this.nGrupo = value; }
		}
        // Constructor
        public Obrero(string nombreObrero, string apellidoObrero,string cargoObrero,int dniObrero, int nroLegajoObrero, int sueldoObrero,int numeroGrupo){
		
			this.nombre=nombreObrero;
			this.apellido =apellidoObrero;
			this.cargo = cargoObrero;
			this.dni = dniObrero;
			this.nroLegajo = nroLegajoObrero;
			this.sueldo = sueldoObrero;
			this.nGrupo = numeroGrupo;
		}
	}
	public class JefeObrero : Obrero{
		private int bonificacion,numeroGrupo;
		private ArrayList grupo;
		
		//Propiedades nuevas
		public int Bonificacion{
			get { return bonificacion; }
			set { this.bonificacion = value; }
		}
		public ArrayList GRUPO
		{
			get { return grupo; }
			set { this.grupo = value; }
		}
		public int NUMEROGRUPO {
			get { return numeroGrupo; }
			set { this.numeroGrupo = value; }
		}
		public ArrayList Grupo{get;set;}
		public JefeObrero(string nombre, string apellido, string cargo, int dni, int nroLegajo, int sueldo, int bonificacion, int numeroGrupo,int codObra)
        : base(nombre, apellido, cargo, dni, nroLegajo, sueldo, codObra) // Pasa el nombre al constructor de la clase base
    	{
        this.bonificacion = bonificacion;
		this.numeroGrupo = numeroGrupo;
		this.grupo = new ArrayList();
   		}
		// Funciones
		public void AgregarGrupo(GrupoObrero x){
			this.grupo.Add(x);
		}
	}
	public class GrupoObrero {
		private ArrayList integrantesGrupo = new ArrayList();
		private JefeObrero jefeObra;
		private int codObra, id;
		// Propiedades:

		public ArrayList Grupo {
			get {
				return integrantesGrupo;
			}
			set { this.integrantesGrupo = value; }
		}
		public int CodObra {
			get {
				return codObra;
			}
			set { this.codObra = value; }
		}
		public int ID {
			get {
				return id;
			}
			set { this.id = value; }
		}
		public JefeObrero JEFEOBREROGRUPO{
			get{ return jefeObra; }
			set {this.jefeObra = value; }
		}
		// Constructor
		public GrupoObrero(int x,int b){
			this.codObra = x;
			this.id = b;
		}
		
		//Funciones
		public void AgregarIntegrante(Obrero x){
			integrantesGrupo.Add(x);
		}
		public int Integrantes(){
			int cantidadIntegrantes = integrantesGrupo.Count;
			return cantidadIntegrantes;
		}
		public void EliminarObrero(Obrero x){
			integrantesGrupo.Remove(x);
		}
        public void EliminarJefeObrero(JefeObrero x)
        {
			this.jefeObra = null;
        }
        public bool EncontrarObrero(string x){
			return integrantesGrupo.Contains(x);
		}
		public void DatosIntegrantes(){
			foreach (ArrayList element in integrantesGrupo) {
				int vueltas = (element.Count - 1);
				for (int i = 0; i < vueltas; i++) {
					int b = i+1;
					Console.WriteLine("NOMBRE:" + element[i]+ "-" +"APELLIDO:"+element[b]);
				}
			}
		}
		public void ActualizarLista(ArrayList x){
			integrantesGrupo = x;
		}
		public bool VerificacionJefe() {
			bool verifi = false;
			if (jefeObra == null)
			{
				return verifi;
			}
			else { 
				verifi = true;
				return verifi;
			}
		}
	}
	public class NoHayGruposLibresException : Exception{
		public string motivo;
		public NoHayGruposLibresException(string x){
			motivo = x;
		}
	}
    public class ObraNoEncontrada : Exception
    {
        public string motivo;
        public ObraNoEncontrada(string x)
        {
            motivo = x;
        }
    }
}
	

