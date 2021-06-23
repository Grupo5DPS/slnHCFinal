using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using CapaEntidad;
using CapaNegocio;
using System.Data;

namespace CapaServicio
{

    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    public class WebService1 : System.Web.Services.WebService
    {
        //---------------------------------- PACIENTE ------------------------------------------

        [WebMethod(Description = "Listar pacientes")]
        public DataSet ListarPaciente()
        {
            Paciente pacientee = new Paciente();
            return pacientee.Listar();
        }


        [WebMethod(Description = "Agregar paciente")]
        public string[] AgregarPaciente(string idPaciente, string nombre, string apellidoPaterno, string apellidoMaterno,
            string dni, string edad, string sexo, string fechaNacimiento, string estadoCivil, string ocupacion,
            string direccion, string telefono, string fechaIngreso)
        {
            //PacienteE paciente = new PacienteE();
            Paciente pacientee = new Paciente();
            return pacientee.Agregar(idPaciente, nombre, apellidoPaterno, apellidoMaterno, dni, edad, sexo, fechaNacimiento, estadoCivil, ocupacion, direccion, telefono, fechaIngreso);
        }
        [WebMethod(Description = "Eliminar paciente")]
        public string[] EliminarPaciente(string idPaciente)
        {

        Paciente pacientee = new Paciente();
            return pacientee.Eliminar(idPaciente);
    }
        [WebMethod(Description = "Buscar paciente")]
        public DataSet BuscarPaciente(string idPaciente)
        {

            Paciente pacientee = new Paciente();
            return pacientee.Buscar(idPaciente);
        }
        [WebMethod(Description = "Actualizar paciente")]
        public string[] ActualizarPaciente(string idPaciente, string nombre, string apellidoPaterno, string apellidoMaterno,
            string dni, string edad, string sexo, string fechaNacimiento, string estadoCivil, string ocupacion,
            string direccion, string telefono, string fechaIngreso)
        {
            //PacienteE paciente = new PacienteE();
            Paciente pacientee = new Paciente();
            return pacientee.Actualizar(idPaciente, nombre, apellidoPaterno, apellidoMaterno, dni, edad, sexo, fechaNacimiento, estadoCivil, ocupacion, direccion, telefono, fechaIngreso);
        }

        //---------------------------------- HOSPITAL ------------------------------------------

        [WebMethod(Description = "Listar hospitales")]
        public DataSet ListarHospital()
        {
            Hospital hospitall = new Hospital();
            return hospitall.Listar();
        }



        [WebMethod(Description = "Agregar hospitales")]
        public string[] AgregarHospitales(string idHo, string nombreHospital, string direccion)
        {
            Hospital hospitall = new Hospital();
            return hospitall.Agregar(idHo, nombreHospital, direccion);
        }
        [WebMethod(Description = "Eliminar hospitales")]
        public string[] EliminarHospital(string idHo)
        {

            Hospital hospital = new Hospital();
            return hospital.Eliminar(idHo);

        }
        [WebMethod(Description = "Buscar hospitales")]
        public DataSet BuscarHospital(string idHo)
        {

            Hospital hospital = new Hospital();
            return hospital.Buscar(idHo);

        }
        [WebMethod(Description = "Actualizar hospitales")]
        public string[] ActualizarHospitales(string idHo, string nombreHospital, string direccion)
        {
            Hospital hospitall = new Hospital();
            return hospitall.Actualizar(idHo, nombreHospital, direccion);
        }

        //---------------------------------- HISTORIA ------------------------------------------

        [WebMethod(Description = "Listar historias")]
        public DataSet ListarHistorias()
        {
            Historia historiaa = new Historia();
            return historiaa.Listar();
        }



        [WebMethod(Description = "Agregar historia")]
        public string[] AgregarHistorias(string idHistoria, string peso, string talla, string motivo,
            string sintomas, string adicciones, string motivoConsulta, string idPaciente, string idDoctor,
            string idUsuario, string idHospital, string idAntecedentesP, string idAntecedentesF, string idAntecedentesQ,
            string codDiagnostico, string fechaRegistro)
        {
            Historia historiaa = new Historia();
            return historiaa.Agregar(idHistoria, peso, talla, motivo,
                                    sintomas, adicciones, motivoConsulta,
                                    idPaciente, idDoctor, idUsuario, idHospital,
                                    idAntecedentesP, idAntecedentesF, idAntecedentesQ, codDiagnostico, fechaRegistro);
        }

        [WebMethod(Description = "Eliminar Historia")]
        public string[] EliminarHistoria(string idHistoria)
        {
            Historia historia = new Historia();
            return historia.Eliminar(idHistoria);

        }
        [WebMethod(Description = "Buscar Historia")]
        public DataSet BuscarHistoria(string idHistoria)
        {
            Historia historia = new Historia();
            return historia.Buscar(idHistoria);

        }

        [WebMethod(Description = "Actualizar historia")]
        public string[] ActualizarHistorias(string idHistoria, string peso, string talla, string motivo,
            string sintomas, string adicciones, string motivoConsulta, string idPaciente, string idDoctor,
            string idUsuario, string idHospital, string idAntecedentesP, string idAntecedentesF, string idAntecedentesQ,
            string codDiagnostico, string fechaRegistro)
        {
            Historia historiaa = new Historia();
            return historiaa.Actualizar(idHistoria, peso, talla, motivo,
                                    sintomas, adicciones, motivoConsulta,
                                    idPaciente, idDoctor, idUsuario, idHospital,
                                    idAntecedentesP, idAntecedentesF, idAntecedentesQ, codDiagnostico, fechaRegistro);
        }

        //---------------------------------- Usuario ------------------------------------------

        [WebMethod(Description = "Listar Usuario")]
        public DataSet ListarUsuarios()
        {
            User    usuario = new User();
            return  usuario.Listar();
        }
        [WebMethod(Description = "Agregar Usuario")]
        public string[] AgregarUsuario(string idUsuario, string usuario, string contrasenia)
        {
            User us = new User();
            return us.Agregar(idUsuario, usuario, contrasenia);
        }
        [WebMethod(Description = "Eliminar Usuario")]
        public string[] EliminarUsuario(string idUsuario)
        {
            User us = new User();
            return us.Eliminar(idUsuario);
        }
        [WebMethod(Description = "Buscar Usuario")]
        public DataSet BuscarUsuario(string idUsuario)
        {
            User us = new User();
            return us.Buscar(idUsuario);
        }
        [WebMethod(Description = "Actualizar Usuario")]
        public string[] ActualizarUsuario(string idUsuario, string usuario, string contrasenia)
        {
            User us = new User();
            return us.Actualizar(idUsuario, usuario, contrasenia);
        }
        //---------------------------------- DOCTORES ------------------------------------------

        [WebMethod(Description = "Listar Doctores")]
        public DataSet Listardoctor()
        {

            Doctor doctor = new Doctor();
            return doctor.listar();
        }
        [WebMethod(Description = "Agregar Doctores")]
        public string[] AgregarDoctores(string IDdoctor,
                                string nombre,
                                string apellidoPaterno,
                                string apellidoMaterno,
                                string Especialidad,
                                string direccion,
                                string telefono,
                                string idHospital)
        {
            Doctor doctor = new Doctor();
            return doctor.Agregar( IDdoctor,
                                 nombre,
                                 apellidoPaterno,
                                 apellidoMaterno,
                                 Especialidad,
                                 direccion,
                                 telefono,
                                 idHospital);
        }

        [WebMethod(Description = "Eliminar Doctor")]
        public string[] EliminarDoctor(string idDoctor)
        {
            Doctor doctor = new Doctor();
            return doctor.Eliminar(idDoctor);

        }
        [WebMethod(Description = "Buscar Doctor")]
        public DataSet BuscarDoctor(string idDoctor)
        {

            
            Doctor doctor = new Doctor();
            return doctor.Buscar(idDoctor);

        }
        [WebMethod(Description = "Actualizar Doctores")]
        public string[] ActualizarDoctores(string IDdoctor,
                                string nombre,
                                string apellidoPaterno,
                                string apellidoMaterno,
                                string Especialidad,
                                string direccion,
                                string telefono,
                                string idHospital)
        {
            Doctor doctor = new Doctor();
            return doctor.Actualizar(IDdoctor,
                                 nombre,
                                 apellidoPaterno,
                                 apellidoMaterno,
                                 Especialidad,
                                 direccion,
                                 telefono,
                                 idHospital);
        }
        //---------------------------------- DIAGNOSTICO ------------------------------------------

        [WebMethod(Description = "Listar Diagnostico")]
        public DataSet ListarDiagnostico()
        {

            Diagnostico diagnostico = new Diagnostico();
            return diagnostico.Listar();
        }
        [WebMethod(Description = "Agregar Diagnostico")]
        public string[] AgregarDiagnostico(string codDiagnostico, string descripcion)
        {
            Diagnostico diagnostico = new Diagnostico();
            return diagnostico.Agregar(codDiagnostico, descripcion);
        }
        [WebMethod(Description = "Eliminar Diagnostico")]
        public string[] EliminarDiagnostico(string codDiagnostico)
        {
            Diagnostico diagnostico = new Diagnostico();
            return diagnostico.Eliminar(codDiagnostico);

        }
        [WebMethod(Description = "Buscar Diagnostico")]
        public DataSet BuscarDiagnostico(string codDiagnostico)
        {
            Diagnostico diagnostico = new Diagnostico();
            return diagnostico.Buscar(codDiagnostico);

        }

        [WebMethod(Description = "Actualizar Diagnostico")]
        public string[] ActualizarDiagnostico(string codDiagnostico, string descripcion)
        {
            Diagnostico diagnostico = new Diagnostico();
            return diagnostico.Actualizar(codDiagnostico, descripcion);
        }
        //----------------------------------Antecedentes Familiares ------------------------------------------

        [WebMethod(Description = "Listar Antecedentes Familiares")]
        public DataSet ListarAntecedentesFamiliares()
        {
            AntecedentesFamiliares antecedentesFamiliares = new AntecedentesFamiliares();
            return antecedentesFamiliares.Listar();
        }
        [WebMethod(Description = " Agregar Antecedentes Familiares")]
        public string[] AgregarAntecedentesF(string idAntecedenteF, string diabetes, string cancer, string tuberculosis, string ipertencion, string sida, string covid, string otrasenfermedades)
        {
            AntecedentesFamiliares AF = new AntecedentesFamiliares(); 
            return AF.Agregar( idAntecedenteF,  diabetes,  cancer,  tuberculosis,  ipertencion,  sida,  covid,  otrasenfermedades);
        }
        [WebMethod(Description = "Eliminar Antecedentes Familiares")]
        public string[] EliminarAntecedentesF(string idAntecedenteF)
        {
            AntecedentesFamiliares AF = new AntecedentesFamiliares();
            return AF.Eliminar(idAntecedenteF);

        }
        [WebMethod(Description = "Buscar Antecedentes Familiares")]
        public DataSet BuscarAntecedentesF(string idAntecedenteF)
        {
            AntecedentesFamiliares AF = new AntecedentesFamiliares();
            return AF.Buscar(idAntecedenteF);

        }
        [WebMethod(Description = " Actualizar Antecedentes Familiares")]
        public string[] ActualizarAntecedentesF(string idAntecedenteF, string diabetes, string cancer, string tuberculosis, string ipertencion, string sida, string covid, string otrasenfermedades)
        {
            AntecedentesFamiliares AF = new AntecedentesFamiliares();
            return AF.Actualizar(idAntecedenteF, diabetes, cancer, tuberculosis, ipertencion, sida, covid, otrasenfermedades);
        }
        //----------------------------------Antecedentes Personales ------------------------------------------

        [WebMethod(Description = "Listar Antecedentes Personales")]
        public DataSet ListarAntecedentesPersonales()
        {

            AntecedentesPersonales antecedentesPersonales = new AntecedentesPersonales();
            return antecedentesPersonales.Listar();
        }
        [WebMethod(Description = "Agregar Antecedentes Personales")]
        public string[] AgregarAntecedentesP(string idAntecedenteP, string relacionesSexuales, string edadSexInicio, string sexFrecuencia, string nroParejas, string usasProteccion, string vacunaSarampion, string vacunaViruela, string vacunaRabia, string vacunaFiebreA, string vacunaHepatitis, string otrasVacunas)
        {
            AntecedentesPersonales AP = new AntecedentesPersonales();
            return AP.Agregar( idAntecedenteP,  relacionesSexuales,  edadSexInicio,  sexFrecuencia,  nroParejas,  usasProteccion,  vacunaSarampion,  vacunaViruela,  vacunaRabia,  vacunaFiebreA,  vacunaHepatitis,  otrasVacunas);
        }
        [WebMethod(Description = "Eliminar Antecedentes Personales")]
        public string[] EliminarAntecedentesP(string idAntecedenteP)
        {
            AntecedentesPersonales AP = new AntecedentesPersonales();
            return AP.Eliminar(idAntecedenteP);
        }
        [WebMethod(Description = "Buscar Antecedentes Personales")]
        public DataSet BuscarAntecedentesP(string idAntecedenteP)
        {
            AntecedentesPersonales AP = new AntecedentesPersonales();
            return AP.Buscar(idAntecedenteP);
        }
        [WebMethod(Description = "Actualizar Antecedentes Personales")]
        public string[] ActualizarAntecedentesP(string idAntecedenteP, string relacionesSexuales, string edadSexInicio, string sexFrecuencia, string nroParejas, string usasProteccion, string vacunaSarampion, string vacunaViruela, string vacunaRabia, string vacunaFiebreA, string vacunaHepatitis, string otrasVacunas)
        {
            AntecedentesPersonales AP = new AntecedentesPersonales();
            return AP.Actualizar(idAntecedenteP, relacionesSexuales, edadSexInicio, sexFrecuencia, nroParejas, usasProteccion, vacunaSarampion, vacunaViruela, vacunaRabia, vacunaFiebreA, vacunaHepatitis, otrasVacunas);
        }
        //----------------------------------Antecedentes Quirurjicos ------------------------------------------

        [WebMethod(Description = "Listar Antecedentes Quirurjicos")]
        public DataSet ListarAntecedentesQuirurjicoss()
        {

            AntecedentesQuirurjicos antecedentesQuirurjicos = new AntecedentesQuirurjicos();
            return antecedentesQuirurjicos.Listar();
        }
        [WebMethod(Description = "Agregar Antecedentes Quirurjicos")]
        public string[] AgregarAntecedentesQ(string idAntecedenteQ, string tuvoIntervencion, string nroVeces, string causaOperacion, string alergias, string queAlergias, string sufreDiabetes, string sufreEpilepsia, string sufreHipertension, string otrasEnfermedades, string medicamentos, string queMedicamento)
        {
            AntecedentesQuirurjicos AQ = new AntecedentesQuirurjicos(); 
            return AQ.Agregar( idAntecedenteQ,  tuvoIntervencion,  nroVeces,  causaOperacion,  alergias,  queAlergias,  sufreDiabetes,  sufreEpilepsia,  sufreHipertension,  otrasEnfermedades,  medicamentos,  queMedicamento);
        }
        [WebMethod(Description = "Eliminar Antecedentes Quirurjicos")]
        public string[] EliminarAntecedentesQ(string idAntecedenteQ)
        {
            AntecedentesQuirurjicos AQ = new AntecedentesQuirurjicos();
            return AQ.Eliminar(idAntecedenteQ);

        }
        [WebMethod(Description = "Buscar Antecedentes Quirurjicos")]
        public DataSet BuscarAntecedentesQ(string idAntecedenteQ)
        {
            AntecedentesQuirurjicos AQ = new AntecedentesQuirurjicos();
            return AQ.Buscar(idAntecedenteQ);
        }
        [WebMethod(Description = "Actualizar Antecedentes Quirurjicos")]
        public string[] ActualizarAntecedentesQ(string idAntecedenteQ, string tuvoIntervencion, string nroVeces, string causaOperacion, string alergias, string queAlergias, string sufreDiabetes, string sufreEpilepsia, string sufreHipertension, string otrasEnfermedades, string medicamentos, string queMedicamento)
        {
            AntecedentesQuirurjicos AQ = new AntecedentesQuirurjicos();
            return AQ.Actualizar(idAntecedenteQ, tuvoIntervencion, nroVeces, causaOperacion, alergias, queAlergias, sufreDiabetes, sufreEpilepsia, sufreHipertension, otrasEnfermedades, medicamentos, queMedicamento);
        }

    }

}
