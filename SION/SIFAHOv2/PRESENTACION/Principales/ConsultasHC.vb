﻿Public Class ConsultasHC
    'CADENAS PARA VISTA_PREVIA
    Public Const VISTA_PREVIA_CREAR = "[PROC_VISTA_PREVIA_CREAR]"
    Public Const VISTA_PREVIA_CREAR_PARTE1 = "[PROC_VISTA_PREVIA_PARTE1_CREAR]"
    Public Const VISTA_PREVIA_CREAR_PARTE2 = "[PROC_VISTA_PREVIA_PARTE2_CREAR]"
    Public Const VISTA_PREVIA_CREAR_PARTE3 = "[PROC_VISTA_PREVIA_PARTE3_CREAR]"
    Public Const VISTA_PREVIA_CREAR_PARTE4 = "[PROC_VISTA_PREVIA_PARTE4_CREAR]"
    Public Const VISTA_PREVIA_ACTUALIZAR = "[PROC_VISTA_PREVIA_ACTUALIZAR]"
    Public Const VISTA_PREVIA_ACTUALIZAR_PARTE1 = "[PROC_VISTA_PREVIA_PARTE1_ACTUALIZAR]"
    Public Const VISTA_PREVIA_ACTUALIZAR_PARTE2 = "[PROC_VISTA_PREVIA_PARTE2_ACTUALIZAR]"
    Public Const VISTA_PREVIA_ACTUALIZAR_PARTE3 = "[PROC_VISTA_PREVIA_PARTE3_ACTUALIZAR]"
    Public Const VISTA_PREVIA_ACTUALIZAR_PARTE4 = "[PROC_VISTA_PREVIA_PARTE4_ACTUALIZAR]"
    Public Const VISTA_PREVIA_VERIFICAR = " EXEC PROC_VISTA_PREVIA_VERIFICAR "
    Public Const VISTA_PREVIA_VERIFICAR_2DOPLANO = " EXEC PROC_VISTA_PREVIA_2DOPLANO_VERIFICAR "
    Public Const VISTA_PREVIA_DOC_LISTAR = " EXEC PROC_VISTA_PREVIA_REGISTRO_LISTAR "
    Public Const VISTA_PREVIA_DOC_BD_LISTAR = " EXEC PROC_VISTA_PREVIA_BD_REGISTRO_LISTAR "
    Public Const VISTA_PREVIA_DOC_BD_LISTAR_R = " EXEC PROC_VISTA_PREVIA_BD_REGISTRO_LISTAR_R "
    Public Const VISTA_PREVIA_DOC_BD_LISTAR_RR = " EXEC PROC_VISTA_PREVIA_BD_REGISTRO_LISTAR_RR "
    Public Const FAMILIA_REGISTRO_LISTAR = "PROC_FAMILIA_REGISTRO_LISTAR"

    'CADENAS VISTA PREVIA ATENCION
    Public Const VISTA_PREVIA_ATENCION = "PROC_VISTA_PREVIA_ATENCION_LISTAR"
    Public Const VISTA_PREVIA_BD_LISTAR = "PROC_VISTA_PREVIA_BD_ATENCION"
    'CADENAS PARA PREFACTURA
    Public Const PREFACTURA_CREAR = "[PROC_HC_PREFACTURA_CREAR]"
    Public Const PREFACTURA_CREAR_R = "[PROC_HC_PREFACTURA_CREAR_R]"
    Public Const PREFACTURA_CREAR_RR = "[PROC_HC_PREFACTURA_CREAR_RR]"
    Public Const PREFACTURA_ACTUALIZAR = "[PROC_HC_PREFACTURA_ACTUALIZAR]"
    Public Const PREFACTURA_VERIFICAR = " EXEC PROC_HC_PREFACTURA_VERIFICAR "
    Public Const ESTADO_PREFACTURADO_CAMBIAR = " EXEC PROC_ESTADO_PREFACTURADO_CAMBIAR "
    Public Const PREFACTURA_SOAT = "[PROC_HC_PREFACTURA_SOAT_CARGAR]"
    Public Const PREFACTURA_SOAT_R = "[PROC_HC_PREFACTURA_SOAT_CARGAR_R]"
    Public Const PREFACTURA_SOAT_RR = "[PROC_HC_PREFACTURA_SOAT_CARGAR_RR]"

    'LISTADO DE ORDENES DE OXIGENOS
    Public Const OXIGENO_LISTAR = "[PROC_FISIOTERAPIA_OXIGENO_LISTAR]"

    Public Const FECHA_EPICRISIS_VERIFICAR = "PROC_EPICRISIS_FECHA_VERIFICAR"
    Public Const FECHA_EPICRISIS_VERIFICAR_R = "PROC_EPICRISIS_FECHA_VERIFICAR_R"
    Public Const FECHA_EPICRISIS_VERIFICAR_RR = "PROC_EPICRISIS_FECHA_VERIFICAR_RR"

    Public Const OXIGENO_LISTAR_R = "[PROC_FISIOTERAPIA_OXIGENO_LISTAR_R]"
    Public Const OXIGENO_LISTAR_RR = "[PROC_FISIOTERAPIA_OXIGENO_LISTAR_RR]"

    'LISTADO DE nebulizaciones
    Public Const NEBULIZACION_LISTAR = "[PROC_FISIOTERAPIA_NEBULIZACION_LISTAR]"
    Public Const NEBULIZACION_LISTAR_R = "[PROC_FISIOTERAPIA_NEBULIZACION_LISTAR_R]"
    Public Const NEBULIZACION_LISTAR_RR = "[PROC_FISIOTERAPIA_NEBULIZACION_LISTAR_RR]"

    Public Const NEBULIZACION_CARGAR = "[PROC_FISIOTERAPIA_NEBULIZACION_CARGAR]"
    Public Const NEBULIZACION_CARGAR_R = "[PROC_FISIOTERAPIA_NEBULIZACION_CARGAR_R]"
    Public Const NEBULIZACION_CARGAR_RR = "[PROC_FISIOTERAPIA_NEBULIZACION_CARGAR_RR]"

    'CARGA LOS OXIGENOS GUARDADOS 
    Public Const OXIGENO_CARGAR_PRIMERA_VEZ = "[PROC_FISIOTERAPIA_OXIGENO_CARGAR]"
    Public Const OXIGENO_CARGAR_PRIMERA_VEZ_R = "[PROC_FISIOTERAPIA_OXIGENO_CARGAR_R]"
    Public Const OXIGENO_CARGAR_PRIMERA_VEZ_RR = "[PROC_FISIOTERAPIA_OXIGENO_CARGAR_RR]"

    'FECHA DE EGRESO PARA LOS PACIENTES
    Public Const OXIGENO_FECHA_EGRESO = "[PROC_FISIOTERAPIA_OXIGENO_FECHA_EGRESO]"
    Public Const OXIGENO_FECHA_EGRESO_R = "[PROC_FISIOTERAPIA_OXIGENO_FECHA_EGRESO_R]"
    Public Const OXIGENO_FECHA_EGRESO_RR = "[PROC_FISIOTERAPIA_OXIGENO_FECHA_EGRESO_RR]"

    'CAMBIAR MODO DE VENTILACION
    Public Const OXIGENO_BUSCAR_MODO = "[PROC_FISIOTERAPIA_OXIGENO_CAMBIAR_MODO_VENTILACION] ''"
    Public Const OXIGENO_CAMBIAR_MODO = "[PROC_FISIOTERAPIA_OXIGENO_CAMBIAR_MODO_VENTILACION_INDIVIDUAL]"

    'GUARDAR OXIGENOS FISIOTERAPIA
    Public Const OXIGENO_FISIOTERAPIA_GUARDAR = "[PROC_FISIOTERAPIA_OXIGENO_CREAR]"
    Public Const OXIGENO_FISIOTERAPIA_GUARDAR_R = "[PROC_FISIOTERAPIA_OXIGENO_CREAR_R]"
    Public Const OXIGENO_FISIOTERAPIA_GUARDAR_RR = "[PROC_FISIOTERAPIA_OXIGENO_CREAR_RR]"

    'GUARDAR NEBULIZACION 
    Public Const NEBULIZACION_FISIOTERAPIA_GUARDAR = "[PROC_FISIOTERAPIA_NEBULIZACION_CREAR]"
    Public Const NEBULIZACION_FISIOTERAPIA_GUARDAR_R = "[PROC_FISIOTERAPIA_NEBULIZACION_CREAR_R]"
    Public Const NEBULIZACION_FISIOTERAPIA_GUARDAR_RR = "[PROC_FISIOTERAPIA_NEBULIZACION_CREAR_RR]"

    'CADENAS FISIOTERAPIAS
    Public Const FISIOTERAPIA_FISICA_Y_RESPIRATORIA_LISTAR = " EXEC PROC_FISIOTERAPIA_FIS_Y_REPROC_LISTAR "
    Public Const FISIOTERAPIA_FISICA_Y_RESPIRATORIA_LISTAR_R = " EXEC PROC_FISIOTERAPIA_FIS_Y_REPROC_LISTAR_R "
    Public Const FISIOTERAPIA_FISICA_Y_RESPIRATORIA_LISTAR_RR = " EXEC PROC_FISIOTERAPIA_FIS_Y_REPROC_LISTAR_RR "
    Public Const FISIOTERAPIA_FISICA_Y_RESPIRATORIA_CARGAR = " EXEC PROC_FISIOTERAPIA_FIS_Y_REPROC_CARGAR "
    Public Const FISIOTERAPIA_FISICA_Y_RESPIRATORIA_CARGAR_R = " EXEC PROC_FISIOTERAPIA_FIS_Y_REPROC_CARGAR_R "
    Public Const FISIOTERAPIA_FISICA_Y_RESPIRATORIA_CARGAR_RR = " EXEC PROC_FISIOTERAPIA_FIS_Y_REPROC_CARGAR_RR "
    Public Const FISIOTERAPIA_FISICA_Y_RESPIRATORIA_GUARDAR = "PROC_FISIOTERAPIA_FIS_Y_REPROC_GUARDAR"
    Public Const FISIOTERAPIA_FISICA_Y_RESPIRATORIA_GUARDAR_R = "PROC_FISIOTERAPIA_FIS_Y_REPROC_GUARDAR_R"
    Public Const FISIOTERAPIA_FISICA_Y_RESPIRATORIA_GUARDAR_RR = "PROC_FISIOTERAPIA_FIS_Y_REPROC_GUARDAR_RR"

    'CADENAS INSUMOS FISIOTERAPIA
    Public Const FISIOTERAPIA_INSUMO_LISTAR = " EXEC PROC_FISIOTERAPIA_INSUMO_LISTAR "
    Public Const FISIOTERAPIA_INSUMO_LISTAR_R = " EXEC PROC_FISIOTERAPIA_INSUMO_LISTAR_R "
    Public Const FISIOTERAPIA_INSUMO_LISTAR_RR = " EXEC PROC_FISIOTERAPIA_INSUMO_LISTAR_RR "
    Public Const FISIOTERAPIA_INSUMO_ANULAR = " EXEC PROC_FISIOTERAPIA_INSUMO_ANULAR "
    Public Const FISIOTERAPIA_INSUMO_ANULAR_R = " EXEC PROC_FISIOTERAPIA_INSUMO_ANULAR_R "
    Public Const FISIOTERAPIA_INSUMO_ANULAR_RR = " EXEC PROC_FISIOTERAPIA_INSUMO_ANULAR_RR "
    Public Const FISIOTERAPIA_INSUMO_CARGAR = " EXEC PROC_FISIOTERAPIA_INSUMO_CARGAR "
    Public Const FISIOTERAPIA_INSUMO_CARGAR_R = " EXEC PROC_FISIOTERAPIA_INSUMO_CARGAR_R "
    Public Const FISIOTERAPIA_INSUMO_CARGAR_RR = " EXEC PROC_FISIOTERAPIA_INSUMO_CARGAR_RR "
    Public Const FISIOTERAPIA_INSUMO_CREAR = "PROC_FISIOTERAPIA_INSUMO_CREAR"
    Public Const FISIOTERAPIA_INSUMO_CREAR_R = "PROC_FISIOTERAPIA_INSUMO_CREAR_R"
    Public Const FISIOTERAPIA_INSUMO_CREAR_RR = "PROC_FISIOTERAPIA_INSUMO_CREAR_RR"
    Public Const FISIOTERAPIA_INSUMO_ACTUALIZAR = "PROC_FISIOTERAPIA_INSUMO_ACTUALIZAR"
    Public Const FISIOTERAPIA_INSUMO_ACTUALIZAR_R = "PROC_FISIOTERAPIA_INSUMO_ACTUALIZAR_R"
    Public Const FISIOTERAPIA_INSUMO_ACTUALIZAR_RR = "PROC_FISIOTERAPIA_INSUMO_ACTUALIZAR_RR"
    Public Const FISIOTERAPIA_INSUMO_BUSQUEDA = "EXEC [PROC_INSUMO_FISIO_BUSCAR] '',"
    Public Const FISIOTERAPIA_INSUMO_PERIODICIDAD = " EXEC [PROC_PERIODICIDAD_INSUMO_FISIO] "
    Public Const FISIOTERAPIA_INSUMO_PERIODICIDAD_R = " EXEC [PROC_PERIODICIDAD_INSUMO_FISIO_R] "
    Public Const FISIOTERAPIA_INSUMO_PERIODICIDAD_RR = " EXEC [PROC_PERIODICIDAD_INSUMO_FISIO_RR] "
    Public Const FISIOTERAPIA_INSUMO_CONFIGURACION = " EXEC [PROC_ORDEN_FISIO_CONFIG_AUDITORIA_CARGAR] "
    Public Const FISIOTERAPIA_INSUMO_CONFIGURACION_R = " EXEC [PROC_ORDEN_FISIO_CONFIG_AUDITORIA_CARGAR_R] "
    Public Const FISIOTERAPIA_INSUMO_CONFIGURACION_RR = " EXEC [PROC_ORDEN_FISIO_CONFIG_AUDITORIA_CARGAR_RR] "


    'CADENAS NOTA FISIOTERAPIA
    Public Const FISIOTERAPIA_NOTA_LISTAR = " EXEC PROC_FISIOTERAPIA_NOTA_LISTAR "
    Public Const FISIOTERAPIA_NOTA_LISTAR_R = " EXEC PROC_FISIOTERAPIA_NOTA_LISTAR_R "
    Public Const FISIOTERAPIA_NOTA_LISTAR_RR = " EXEC PROC_FISIOTERAPIA_NOTA_LISTAR_RR "
    Public Const FISIOTERAPIA_NOTA_ANULAR = " EXEC PROC_FISIOTERAPIA_NOTA_ANULAR "
    Public Const FISIOTERAPIA_NOTA_ANULAR_R = " EXEC PROC_FISIOTERAPIA_NOTA_ANULAR_R "
    Public Const FISIOTERAPIA_NOTA_ANULAR_RR = " EXEC PROC_FISIOTERAPIA_NOTA_ANULAR_RR "
    Public Const FISIOTERAPIA_NOTA_CREAR = "PROC_FISIOTERAPIA_NOTA_CREAR"
    Public Const FISIOTERAPIA_NOTA_CREAR_R = "PROC_FISIOTERAPIA_NOTA_CREAR_R"
    Public Const FISIOTERAPIA_NOTA_CREAR_RR = "PROC_FISIOTERAPIA_NOTA_CREAR_RR"
    Public Const FISIOTERAPIA_NOTA_ACTUALIZAR = "PROC_FISIOTERAPIA_NOTA_ACTUALIZAR"
    Public Const FISIOTERAPIA_NOTA_ACTUALIZAR_R = "PROC_FISIOTERAPIA_NOTA_ACTUALIZAR_R"
    Public Const FISIOTERAPIA_NOTA_ACTUALIZAR_RR = "PROC_FISIOTERAPIA_NOTA_ACTUALIZAR_RR"

    'CADENAS INSUMOS ENFERMERIA
    Public Const ENFERMERIA_INSUMO_LISTAR = " EXEC PROC_ENFERMERIA_INSUMO_LISTAR "
    Public Const ENFERMERIA_INSUMO_LISTAR_R = " EXEC PROC_ENFERMERIA_INSUMO_LISTAR_R "
    Public Const ENFERMERIA_INSUMO_LISTAR_RR = " EXEC PROC_ENFERMERIA_INSUMO_LISTAR_RR "
    Public Const ENFERMERIA_INSUMO_ANULAR = " EXEC PROC_ENFERMERIA_INSUMO_ANULAR "
    Public Const ENFERMERIA_INSUMO_ANULAR_R = " EXEC PROC_ENFERMERIA_INSUMO_ANULAR_R "
    Public Const ENFERMERIA_INSUMO_ANULAR_RR = " EXEC PROC_ENFERMERIA_INSUMO_ANULAR_RR "
    Public Const ENFERMERIA_INSUMO_CARGAR = " EXEC PROC_ENFERMERIA_INSUMO_CARGAR "
    Public Const ENFERMERIA_INSUMO_CARGAR_R = " EXEC PROC_ENFERMERIA_INSUMO_CARGAR_R "
    Public Const ENFERMERIA_INSUMO_CARGAR_RR = " EXEC PROC_ENFERMERIA_INSUMO_CARGAR_RR "
    Public Const ENFERMERIA_INSUMO_CREAR = "PROC_ENFERMERIA_INSUMO_CREAR"
    Public Const ENFERMERIA_INSUMO_CREAR_R = "PROC_ENFERMERIA_INSUMO_CREAR_R"
    Public Const ENFERMERIA_INSUMO_CREAR_RR = "PROC_ENFERMERIA_INSUMO_CREAR_RR"
    Public Const ENFERMERIA_INSUMO_ACTUALIZAR = "PROC_ENFERMERIA_INSUMO_ACTUALIZAR"
    Public Const ENFERMERIA_INSUMO_ACTUALIZAR_R = "PROC_ENFERMERIA_INSUMO_ACTUALIZAR_R"
    Public Const ENFERMERIA_INSUMO_ACTUALIZAR_RR = "PROC_ENFERMERIA_INSUMO_ACTUALIZAR_RR"
    Public Const ENFERMERIA_INSUMO_BUSQUEDA = "EXEC [PROC_INSUMO_ENFER_BUSCAR] '',"
    Public Const ENFERMERIA_INSUMO_PERIODICIDAD = " EXEC [PROC_PERIODICIDAD_INSUMO_FISIO] "
    Public Const ENFERMERIA_INSUMO_PERIODICIDAD_R = " EXEC [PROC_PERIODICIDAD_INSUMO_FISIO_R] "
    Public Const ENFERMERIA_INSUMO_PERIODICIDAD_RR = " EXEC [PROC_PERIODICIDAD_INSUMO_FISIO_RR] "
    Public Const ENFERMERIA_INSUMO_CONFIGURACION = " EXEC [PROC_ORDEN_ENFER_CONFIG_AUDITORIA_CARGAR] "
    Public Const ENFERMERIA_INSUMO_CONFIGURACION_R = " EXEC [PROC_ORDEN_ENFER_CONFIG_AUDITORIA_CARGAR_R] "
    Public Const ENFERMERIA_INSUMO_CONFIGURACION_RR = " EXEC [PROC_ORDEN_ENFER_CONFIG_AUDITORIA_CARGAR_RR] "

    'CADENAS NOTA ENFERMERIA
    Public Const ENFERMERIA_NOTA_LISTAR = " EXEC PROC_ENFERMERIA_NOTA_LISTAR "
    Public Const ENFERMERIA_NOTA_LISTAR_R = " EXEC PROC_ENFERMERIA_NOTA_LISTAR_R "
    Public Const ENFERMERIA_NOTA_LISTAR_RR = " EXEC PROC_ENFERMERIA_NOTA_LISTAR_RR "
    Public Const ENFERMERIA_NOTA_ANULAR = " EXEC PROC_ENFERMERIA_NOTA_ANULAR "
    Public Const ENFERMERIA_NOTA_ANULAR_R = " EXEC PROC_ENFERMERIA_NOTA_ANULAR_R "
    Public Const ENFERMERIA_NOTA_ANULAR_RR = " EXEC PROC_ENFERMERIA_NOTA_ANULAR_RR "
    Public Const ENFERMERIA_NOTA_CREAR = "PROC_ENFERMERIA_NOTA_CREAR"
    Public Const ENFERMERIA_NOTA_CREAR_R = "PROC_ENFERMERIA_NOTA_CREAR_R"
    Public Const ENFERMERIA_NOTA_CREAR_RR = "PROC_ENFERMERIA_NOTA_CREAR_RR"
    Public Const ENFERMERIA_NOTA_ACTUALIZAR = "PROC_ENFERMERIA_NOTA_ACTUALIZAR"
    Public Const ENFERMERIA_NOTA_ACTUALIZAR_R = "PROC_ENFERMERIA_NOTA_ACTUALIZAR_R"
    Public Const ENFERMERIA_NOTA_ACTUALIZAR_RR = "PROC_ENFERMERIA_NOTA_ACTUALIZAR_RR"
    ' CADENA GLUCOMETRIA ENFERMERIA 
    Public Const ENFERMERIA_EXAMENES_LISTA = "[PROC_EXAMENES_ENFERMERIA_LISTAR]"
    Public Const ENFERMERIA_EXAMENES_LISTA_R = "[PROC_EXAMENES_ENFERMERIA_LISTAR_R]"
    Public Const ENFERMERIA_EXAMENES_LISTA_RR = "[PROC_EXAMENES_ENFERMERIA_LISTAR_RR]"
    Public Const ENFERMERIA_EXAMENES_HEMODERIVADOS_LISTAR = "[PROC_EXAMENES_ENFERMERIA_HEMODERIVADOS_LISTAR]"
    Public Const ENFERMERIA_EXAMENES_HEMODERIVADOS_LISTAR_R = "[PROC_EXAMENES_ENFERMERIA_HEMODERIVADOS_LISTAR_R]"
    Public Const ENFERMERIA_EXAMENES_HEMODERIVADOS_LISTAR_RR = "[PROC_EXAMENES_ENFERMERIA_HEMODERIVADOS_LISTAR_RR]"
    Public Const ENFERMERIA_GLUCOMETRIA_LISTA = "[PROC_ENFERMERIA_GLUCOMETRIA_LISTAR]"
    Public Const ENFERMERIA_GLUCOMETRIA_LISTA_R = "[PROC_ENFERMERIA_GLUCOMETRIA_LISTAR_R]"
    Public Const ENFERMERIA_GLUCOMETRIA_LISTA_RR = "[PROC_ENFERMERIA_GLUCOMETRIA_LISTAR_RR]"
    Public Const ENFERMERIA_GLUCOMETRIA_CARGAR = "[PROC_ENFERMERIA_GLUCOMETRIA]"
    Public Const ENFERMERIA_GLUCOMETRIA_CARGAR_R = "[PROC_ENFERMERIA_GLUCOMETRIA_R]"
    Public Const ENFERMERIA_GLUCOMETRIA_CARGAR_RR = "[PROC_ENFERMERIA_GLUCOMETRIA_RR]"
    Public Const EMPLEADO_INICIALES = " [PROC_INICIALES_EMPLEADO]"
    Public Const ENFERMERIA_GLUCOMETRIA_CREAR = "[PROC_ENFERMERIA_GLUCOMETRIA_CREAR]"
    Public Const ENFERMERIA_GLUCOMETRIA_CREAR_R = "[PROC_ENFERMERIA_GLUCOMETRIA_CREAR_R]"
    Public Const ENFERMERIA_GLUCOMETRIA_CREAR_RR = "[PROC_ENFERMERIA_GLUCOMETRIA_CREAR_RR]"
    '----- EXAMEN RESULTADO

    Public Const RESULTADO_EXAMENES_CARGAR = "EXEC [PROC_RESULTADOS_UNION_EXAMENES_CARGAR] "
    Public Const RESULTADO_EXAMENES_CARGAR_R = "EXEC [PROC_RESULTADOS_UNION_EXAMENES_CARGAR_R] "
    Public Const RESULTADO_EXAMENES_CARGAR_RR = "EXEC [PROC_RESULTADOS_UNION_EXAMENES_CARGAR_RR] "
    Public Const RESULTADO_DOCUMEN_CARGAR = "PROC_RESULTADOS_DOCUMENTO_CARGAR"

    Public Const RESULTADO_EXAMENES_CARGAR_D = "EXEC [PROC_RESULTADOS_UNION_EXAMENES_D_CARGAR] "
    Public Const RESULTADO_EXAMENES_CARGAR_D_R = "EXEC [PROC_RESULTADOS_UNION_EXAMENES_D_CARGAR_R] "
    Public Const RESULTADO_EXAMENES_CARGAR_D_RR = "EXEC [PROC_RESULTADOS_UNION_EXAMENES_D_CARGAR_RR] "
    Public Const RESULTADO_DOCUMEN_CARGAR_D = "PROC_RESULTADOS_DOCUMENTOS_D_CARGAR"

    Public Const RESULTADO_EXAMEN_ANULAR = "[PROC_RESULTADOS_UNION_EXAMENES_ANULAR]"
    Public Const RESULTADO_EXAMEN_ANULAR_R = "[PROC_RESULTADOS_UNION_EXAMENES_ANULAR_R]"
    Public Const RESULTADO_EXAMEN_ANULAR_RR = "[PROC_RESULTADOS_UNION_EXAMENES_ANULAR_RR]"
    Public Const RESULTADO_DOCUMEN_ANULAR = "PROC_RESULTADOS_DOCUMENTOS_ANULAR"

    Public Const RESULTADO_EXAMEN_GUARDAR = "[PROC_RESULTADOS_EXAMENES_CREAR]"
    Public Const RESULTADO_EXAMEN_GUARDAR_R = "[PROC_RESULTADOS_EXAMENES_CREAR_R]"
    Public Const RESULTADO_EXAMEN_GUARDAR_RR = "[PROC_RESULTADOS_EXAMENES_CREAR_RR]"
    Public Const RESULTADO_DOCUMEN_GUARDAR = "[PROC_RESULTADOS_DOCUMENTACION_CREAR]"

    '---PARACLINICOS
    Public Const ENFERMERIA_PARACLICOS_CARGAR = "[PROC_PARACLINICO_ENFERMERIA_CARGAR]"
    Public Const ENFERMERIA_PARACLINICOS_CARGAR_R = "[PROC_PARACLINICO_ENFERMERIA_CARGAR_R]"
    Public Const ENFERMERIA_PARACLINICOS_CARGAR_RR = "[PROC_PARACLINICO_ENFERMERIA_CARGAR_RR]"
    '---HEMODERIVADOS
    Public Const ENFERMERIA_HEMODERIVADOS_CARGAR = "[PROC_HEMODERIVADO_ENFERMERIA_CARGAR]"
    Public Const ENFERMERIA_HEMODERIVADOS_CARGAR_R = "[PROC_HEMODERIVADO_ENFERMERIA_CARGAR_R]"
    Public Const ENFERMERIA_HEMODERIVADOS_CARGAR_RR = "[PROC_HEMORDERIVADO_ENFERMERIA_CARGAR_RR]"
    'IMAGENOLOGIA
    Public Const IMAGENOLOGIA_CARGAR = "EXEC PROC_IMAGENOLOG_CARGAR_PACIENTE_EXAMEN_UNION "
    Public Const IMAGENOLOGIA_CARGAR_R = "EXEC PROC_IMAGENOLOG_CARGAR_PACIENTE_EXAMEN_UNION_R "
    Public Const IMAGENOLOGIA_CARGAR_RR = "EXEC PROC_IMAGENOLOG_CARGAR_PACIENTE_EXAMEN_UNION_RR "

    Public Const IMAGENOLOGIA_CARGAR_HECHOS = "EXEC PROC_IMAGENOLOGIA_CARGAR_PACIENTE_EXAMEN_HECHOS "
    Public Const IMAGENOLOGIA_CARGAR_HECHOS_R = "EXEC PROC_IMAGENOLOGIA_CARGAR_PACIENTE_EXAMEN_HECHOS_R "
    Public Const IMAGENOLOGIA_CARGAR_HECHOS_RR = "EXEC PROC_IMAGENOLOGIA_CARGAR_PACIENTE_EXAMEN_HECHOS_RR "

    'ORDEN MEDICA
    Public Const NUTRICION_POR_DEFECTOS_EDICION = "[PROC_ORDEN_MEDICA_NUTRICION_CARGAR_MEDICAMENTOS_FALTANTES]"
    Public Const NUTRICION_POR_DEFECTOS_EDICION_R = "[PROC_ORDEN_MEDICA_NUTRICION_CARGAR_MEDICAMENTOS_FALTANTES_R]"
    Public Const NUTRICION_POR_DEFECTOS_EDICION_RR = "[PROC_ORDEN_MEDICA_NUTRICION_CARGAR_MEDICAMENTOS_FALTANTES_RR]"
    Public Const NUTRICION_ULTIMO_PESO = "[PROC_ORDEN_MEDICA_NUTRICION_CARGAR_ULTIMO_PESO]"
    Public Const NUTRICION_ULTIMO_PESO_R = "[PROC_ORDEN_MEDICA_NUTRICION_CARGAR_ULTIMO_PESO_R]"
    Public Const NUTRICION_ULTIMO_PESO_RR = "[PROC_ORDEN_MEDICA_NUTRICION_CARGAR_ULTIMO_PESO_RR]"
    '-------PARAMETROS DE VENTILACION 
    Public Const PARAMETRO_VENTILACION_CARGAR = "EXEC [PROC_PARAMETRO_VENTILACION_CARGAR] "
    Public Const PARAMETRO_VENTILACION_CARGAR_R = "EXEC [PROC_PARAMETRO_VENTILACION_CARGAR_R] "
    Public Const PARAMETRO_VENTILACION_CARGAR_RR = "EXEC [PROC_PARAMETRO_VENTILACION_CARGAR_RR] "
    Public Const PARAMETRO_VENTILACION_CODIGO_SABANA_CARGAR = "[PROC_PARAMETRO_CODIGO_CARGAR] "
    Public Const PARAMETRO_VENTILACION_CODIGO_SABANA_CARGAR_R = "[PROC_PARAMETRO_CODIGO_CARGAR_R] "
    Public Const PARAMETRO_VENTILACION_CODIGO_SABANA_CARGAR_RR = "[PROC_PARAMETRO_CODIGO_CARGAR_RR] "

    '-------SABANA DE APLICACION 
    Public Const SABANA_PACIENTE_CARGAR = "[PROC_SABANA_PACIENTE_CARGAR] "
    Public Const SABANA_PACIENTE_CARGAR_R = "[PROC_SABANA_PACIENTE_CARGAR_R] "
    Public Const SABANA_PACIENTE_CARGAR_RR = "[PROC_SABANA_PACIENTE_CARGAR_RR] "
    Public Const SABANA_PESO_CARGAR = "[PROC_SABANA_PESO_CARGAR] "
    Public Const SABANA_PESO_CARGAR_R = "[PROC_SABANA_PESO_CARGAR_R] "
    Public Const SABANA_PESO_CARGAR_RR = "[PROC_SABANA_PESO_CARGAR_RR] "
    Public Const SABANA_CODIGO_CARGAR = "[PROC_SABANA_CODIGO_CARGAR] "
    Public Const SABANA_CODIGO_CARGAR_R = "[PROC_SABANA_CODIGO_CARGAR_R] "
    Public Const SABANA_CODIGO_CARGAR_RR = "[PROC_SABANA_CODIGO_CARGAR_RR] "
    Public Const SABANA_SIGNO_VITAL_CARGAR = "EXEC [PROC_SABANA_SIGNO_VITAL_CARGAR] "
    Public Const SABANA_SIGNO_VITAL_CARGAR_R = "EXEC [PROC_SABANA_SIGNO_VITAL_CARGAR_R] "
    Public Const SABANA_SIGNO_VITAL_CARGAR_RR = "EXEC [PROC_SABANA_SIGNO_VITAL_CARGAR_RR] "
    Public Const SABANA_SILVERMAN_CARGAR = "EXEC [PROC_SABANA_SILVERMAN_CARGAR] "
    Public Const SABANA_VALORACION_CARGAR = "EXEC [PROC_SABANA_VALORACION_CARGAR] "
    Public Const SABANA_EGRESO_CARGAR = "EXEC [PROC_SABANA_EGRESO_CARGAR] "
    Public Const SABANA_EGRESO_CARGAR_R = "EXEC [PROC_SABANA_EGRESO_CARGAR_R] "
    Public Const SABANA_EGRESO_CARGAR_RR = "EXEC [PROC_SABANA_EGRESO_CARGAR_RR] "
    Public Const SABANA_INGRESO_CARGAR = "EXEC [PROC_SABANA_INGRESO_CARGAR] "
    Public Const SABANA_INGRESO_CARGAR_R = "EXEC [PROC_SABANA_INGRESO_CARGAR_R] "
    Public Const SABANA_INGRESO_CARGAR_RR = "EXEC [PROC_SABANA_INGRESO_CARGAR_RR] "
    Public Const SABANA_BALANCE_CARGAR = "EXEC [PROC_SABANA_BALANCE_CARGAR] "
    Public Const SABANA_BALANCE_CARGAR_R = "EXEC [PROC_SABANA_BALANCE_CARGAR_R] "
    Public Const SABANA_BALANCE_CARGAR_RR = "EXEC [PROC_SABANA_BALANCE_CARGAR_RR] "
    Public Const SABANA_APLICACION_MED_CARGAR = "EXEC [PROC_SABANA_APLICACION_MED_CARGAR] "
    Public Const SABANA_APLICACION_MED_CARGAR_R = "EXEC [PROC_SABANA_APLICACION_MED_CARGAR_R] "
    Public Const SABANA_APLICACION_MED_CARGAR_RR = "EXEC [PROC_SABANA_APLICACION_MED_CARGAR_RR] "
    Public Const SABANA_GOTEO_CARGAR = "EXEC [PROC_SABANA_APLICACION_GOTEO_CARGAR] "
    Public Const SABANA_GOTEO_CARGAR_R = "EXEC [PROC_SABANA_APLICACION_GOTEO_CARGAR_R] "
    Public Const SABANA_GOTEO_CARGAR_RR = "EXEC [PROC_SABANA_APLICACION_GOTEO_CARGAR_RR] "
    '----CARGA LOS PACIENTES EXAMEN
    Public Const CARGAR_PACIENTE_EXAMEN = "[PROC_PACIENTE_EXAMEN_CARGAR]"
    Public Const CARGAR_PACIENTE_EXAMEN_R = "[PROC_PACIENTE_EXAMEN_CARGAR_R]"
    Public Const CARGAR_PACIENTE_EXAMEN_RR = "[PROC_PACIENTE_EXAMEN_CARGAR_RR]"
    '-------------- CARGAR PARAMETROS LABORATORIO 
    Public Const CARGAR_PARAMETRO_LABORATORIO = "[PROC_PARACLINICO_RESULTADO_CARGAR]"
    Public Const CARGAR_PARAMETRO_LABORATORIO_R = "[PROC_PARACLINICO_RESULTADO_CARGAR_R]"
    Public Const CARGAR_PARAMETRO_LABORATORIO_RR = "[PROC_PARACLINICO_RESULTADO_CARGAR_RR]"
    '-------------- LABORATORIO  RESULTADO CREAR
    Public Const LABORATORIO_PARACLINICO_CREAR = "[PROC_EXAMEN_PARACLINICO_RESULTADO_CREAR]"
    Public Const LABORATORIO_PARACLINICO_CREAR_R = "[PROC_EXAMEN_PARACLINICO_RESULTADO_CREAR_R]"
    Public Const LABORATORIO_PARACLINICO_CREAR_RR = "[PROC_EXAMEN_PARACLINICO_RESULTADO_CREAR_RR]"
    '-------------- LABORATORIO  RESULTADO CREAR
    Public Const LABORATORIO_PARACLINICO_ANULAR = "[PROC_EXAMEN_PARACLINICO_RESULTADO_ANULADO]"
    Public Const LABORATORIO_PARACLINICO_ANULAR_R = "[PROC_EXAMEN_PARACLINICO_RESULTADO_ANULADO_R]"
    Public Const LABORATORIO_PARACLINICO_ANULAR_RR = "[PROC_EXAMEN_PARACLINICO_RESULTADO_ANULADO_RR]"
    '---------SOLICITUD LABORATORIO 
    Public Const LISTA_LABORATORIO_CARGAR = "[PROC_LISTA_LABORATORIO_CARGAR]"
    '----------CARGAR LABORATORIO 
    Public Const EXAMEN_LABORATORIO_CARGAR = "[PROC_EXAMEN_LABORATORIO_CARGAR]"
    Public Const EXAMEN_LABORATORIO_CARGAR_R = "[PROC_EXAMEN_LABORATORIO_CARGAR_R]"
    Public Const EXAMEN_LABORATORIO_CARGAR_RR = "[PROC_EXAMEN_LABORATORIO_CARGAR_RR]"
    Public Const EXAMEN_LABORATORIO_ATENCION_CARGAR = "[PROC_EXAMEN_LABORATORIO_ATENCION_CARGAR]"
    '-------GUARDAR LABORATORIO
    Public Const EXAMEN_LABORATORIO_GUARDAR = "PROC_EXAMEN_LABORATORIO_CREAR"
    Public Const EXAMEN_LABORATORIO_GUARDAR_R = "PROC_EXAMEN_LABORATORIO_CREAR_R"
    Public Const EXAMEN_LABORATORIO_GUARDAR_RR = "PROC_EXAMEN_LABORATORIO_CREAR_RR"
    '-------BUSCAR SOLICITUD
    Public Const SOLICITUD_LABORATORIO_BUSCAR = "[PROC_SOLICITUD_LABORATORIO_BUSCAR]"
    Public Const SOLICITUD_LABORATORIO_BUSCAR_R = "[PROC_SOLICITUD_LABORATORIO_BUSCAR_R] ''"
    Public Const SOLICITUD_LABORATORIO_BUSCAR_RR = "[PROC_SOLICITUD_LABORATORIO_BUSCAR_RR] ''"
    '---CONSULTAR EL CODIGO TIPO EXAMEN
    Public Const CODIGO_TIPO_EXAMEN_CONSULTAR = "[PROC_CODIGO_TIPO_EXAMEN_CONSULTAR]"
    '------------------------------------------------------------------------------
    Public Const CODIGO_AREA_SERVICIO_CONSULTAR = "[PROC_CODIGO_AREA_SERVICIO_CONSULTAR]"
    '----------------------------------------------------------------------------------
    Public Const CODIGO_APLICA_PARACLINICO = "[PROC_CODIGO_APLICA_PARACLINICO_CONSULTAR]"
    '-----------------------------------------------------------------------------------
    Public Const CONSULTAR_FORMULARIO = "SELECT dbo.FN_CONSULTAR_FORMULARIO_NOTA_AUD('$') bandera"
    '----CARGAR SOLICITUD 
    Public Const SOLICITUD_LABORATORIO_CARGAR = "[PROC_SOLICITUD_LABORATORIO_CARGAR]"
    Public Const SOLICITUD_LABORATORIO_CARGAR_R = "[PROC_SOLICITUD_LABORATORIO_CARGAR_R]"
    Public Const SOLICITUD_LABORATORIO_CARGAR_RR = "[PROC_SOLICITUD_LABORATORIO_CARGAR_RR]"
    '----------ANULAR SOLICITUD
    Public Const SOLICITUD_LABORATORIO_ANULAR = "[PROC_SOLICITUD_LABORATORIO_ANULAR]"
    Public Const SOLICITUD_LABORATORIO_ANULAR_R = "[PROC_SOLICITUD_LABORATORIO_ANULAR_R]"
    Public Const SOLICITUD_LABORATORIO_ANULAR_RR = "[PROC_SOLICITUD_LABORATORIO_ANULAR_RR]"

    '--------VERIFICA SI EXISTE SOLICITUD DE LABORATORIO PARA IMPEDIR ANULAR O EDITAR
    Public Const SOLICITUD_LABORATORIO_VERIFICAR = "[PROC_SOLICITUD_LAB_VERIFICAR]"

    '------ VERIFICA SI EXISTE ORDEN MAYOR Y MENOR QUE SU DIFERENCIA EN HORAS SEA MAYOR A 2
    Public Const ORDEN_MEDICA_INTERMEDIA_VERIFICAR = "[PROC_ORDEN_MEDICA_INTERMEDIA_VERIFICAR]"

    '------ VERIFICA SI ESTADO DEL PACIENTE ES SIN VISADO Y LO COLOCA VISADO, VICEVERSA.
    Public Const CAMBIAR_ESTADO_VISADO = "[PROC_ADMISION_VISADO]"

    '------ VERIFICA SI EXISTE ORDEN dDE COMIDA ES PERMITIDA
    Public Const ORDEN_MEDICA_HORA_COMIDA_VERIFICAR = "[PROC_ORDEN_MEDICA_HORA_COMIDA_VERIFICAR]"
    Public Const REGISTRO_SOLICITUD_VERIFICAR = "[PROC_ANEXO3_REGISTRO_SOLICITUD_VERIFICAR]"
    Public Const REGISTRO_ANEXO3_VERIFICAR = "[PROC_ANEXO3_REGISTRO_VERIFICAR]"
    Public Const AREA_TRASLADO_SOLICITUD_VERIFICAR = "[PROC_ANEXO3_AREA_SOLICITUD_VERIFICAR]"
    Public Const ORDEN_PROCEDIMIENTO_HEMO_VERIFICAR = "[PROC_ORDEN_MEDICA_PROCEDIMIENTO_HEMO_VERIFICAR]"

    '---- VERIFICA SI EXISTE SOLICITUD DE TRASLADO DE AREA
    Public Const VERIFICAR_ADMISION_TRASLADO = "ADMISION_TRASLADO_VERIFICAR"
    Public Const ADMISION_TRASLADO_CREAR = "ADMISION_TRASLADO_CREAR"
    Public Const ADMISION_TRASLADO_ANULAR = "ADMISION_TRASLADO_ANULAR"
    Public Const BUSQUEDA_ADMISION_PARTO = "ADMISION_PARTO_BUSCAR"
    '--------------TRAE EL CODIGO DEL GRUPO DEL EXAMEN --------------
    Public Const ORDEN_MEDICA_CARGA_GRUPO_PROCEDIMIENTO = "[PROC_ORDEN_MEDICA_PROCEDIMIENTO_CARGAR_GRUPO]"

    Public Const NOTA_AUDITORIA_LISTAR = "PROC_NOTA_AUDITORIA_LISTAR"
End Class