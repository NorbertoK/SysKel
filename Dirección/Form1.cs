using System;
using System.Windows.Forms;
using Infragistics.Win.UltraWinGrid;

namespace Dirección
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ButtonCancelarClick(object sender, EventArgs e)
        {
            Close();
        }

        private static void Form1Load(object sender, EventArgs e)
        {
            /*Mensajes WinGrid en Español*/
            var resCust = Resources.Customizer;
            resCust.SetCustomizedString("DeleteSingleRowPrompt",
                                        "Está a punto de borrar un renglón." + Environment.NewLine + "¿Está seguro?");
            //resCust.SetCustomizedString("DataErrorRowUpdateUnableToUpdateRow",
            //                            "El item entre comillas no puede estar vacío. {0},LDR_RowLayoutColumnInfo_P_OriginY");
            resCust.SetCustomizedString("DataErrorRowUpdateUnableToUpdateRow",
                                        "{0}");
            resCust.SetCustomizedString("DataErrorMessageTitle", "Error de Datos");
            resCust.SetCustomizedString("DataErrorRowAddMessage", "Imposible agregar un renglón.");
            resCust.SetCustomizedString("DeleteSingleRowMessageTitle", "Borrar Renglón");
            resCust.SetCustomizedString("DataErrorCellUpdateUnableToUpdateValue", "Imposible actualizar el dato: {0}");
            resCust.SetCustomizedString("ErrMSgEditorValNotValid", "Hay un valor no válido");
            resCust.SetCustomizedString("DeleteMultipleRowsPrompt",
                                        "Ha seleccionado {0} renglones para borrar. Pulse Si para borrarlos o No para salir.");
            resCust.SetCustomizedString("MaskValidationErrorInputExceedsMax",
                                        "El valor que intenta ingresar es mayor que el máximo permitido.");
            resCust.SetCustomizedString("MaskValidationErrorInputSmallerThanMin",
                                        "El valor que intenta ingresar es menor que el mínimo permitido.");
            resCust.SetCustomizedString("RowFilterDropDownAllItem",
                                        "(Todos)");
            resCust.SetCustomizedString("RowFilterDropDownBlanksItem",
                                        "(Vacíos)");
            resCust.SetCustomizedString("RowFilterDropDownNonBlanksItem",
                                        "(Cargados)");
            resCust.SetCustomizedString("RowFilterDropDownCustomItem",
                                        "(Personalizado)");
            resCust.SetCustomizedString("RowFilterDialogBlanksItem",
                                        "(En Blanco)");
            resCust.SetCustomizedString("RowFilterDialogDBNullItem",
                                        "Nulo");
            resCust.SetCustomizedString("RowFilterDialogEmptyTextItem",
                                        "(Texto vacío)");
            resCust.SetCustomizedString("RowFilterDropDown_Operator_Contains",
                                        "Contiene");
            resCust.SetCustomizedString("RowFilterDropDown_Operator_DoesNotContain",
                                        "No contiene");
            resCust.SetCustomizedString("RowFilterDropDown_Operator_DoesNotEndWith",
                                        "No termina con");
            resCust.SetCustomizedString("RowFilterDropDown_Operator_DoesNotMatch",
                                        "No coincide con");
            resCust.SetCustomizedString("RowFilterDropDown_Operator_DoesNotStartWith",
                                        "No empieza con");
            resCust.SetCustomizedString("RowFilterDropDown_Operator_EndsWith",
                                        "Termina con");
            resCust.SetCustomizedString("RowFilterDropDown_Operator_Like",
                                        "Similar");
            resCust.SetCustomizedString("RowFilterDropDown_Operator_Match",
                                        "Coincide con");
            resCust.SetCustomizedString("RowFilterDropDown_Operator_NotLike",
                                        "No es Similar");
            resCust.SetCustomizedString("RowFilterDropDown_Operator_StartsWith",
                                        "Comienza con");
            resCust.SetCustomizedString("RowFilterDropDownEquals",
                                        "Igual a");
            resCust.SetCustomizedString("RowFilterDropDownGreaterThan",
                                        "Mayor que");
            resCust.SetCustomizedString("RowFilterDropDownGreaterThanOrEqualTo",
                                        "Mayor o igual que");
            resCust.SetCustomizedString("RowFilterDropDownLessThan",
                                        "Menor que");
            resCust.SetCustomizedString("RowFilterDropDownLessThanOrEqualTo",
                                        "Menor o igual que");
            resCust.SetCustomizedString("RowFilterDropDownNotEquals",
                                        "No es igual que");
            resCust.SetCustomizedString("RowFilterLogicalOperator_And",
                                        "Y");
            resCust.SetCustomizedString("RowFilterLogicalOperator_Or",
                                        "O");
            resCust.SetCustomizedString("FilterDialogTitle",
                                        "Filtro Personalizado");
            resCust.SetCustomizedString("RowFilterDropDownLike",
                                        "Similar");
            resCust.SetCustomizedString("RowFilterDropDownMatch",
                                        "Coincide Expresión Regular");
            resCust.SetCustomizedString("FilterClearButtonToolTip_FilterCell",
                                        "Click aquí para borrar el criterio de filtro de {0}.");
            resCust.SetCustomizedString("FilterClearButtonToolTip_RowSelector",
                                        "Click aquí para borrar todos los criterios de filtro");
            resCust.SetCustomizedString("FilterDialogAllComboItem",
                                        "todas");
            resCust.SetCustomizedString("FilterDialogAnyComboItem",
                                        "alguna de");
            resCust.SetCustomizedString("FilterDialogApplyLabelText",
                                        "Filtro basado en {0} las siguientes condiciones:");
            resCust.SetCustomizedString("FilterDialogCancelButtonText",
                                        "&Cancelar");
            resCust.SetCustomizedString("FilterDialogConditionAddButtonText",
                                        "&Agregar");
            resCust.SetCustomizedString("FilterDialogConditionDeleteButtonText",
                                        "&Eliminar");
            resCust.SetCustomizedString("FilterDialogDeleteButton_AccessibleDescription",
                                        "Elimina la condición seleccionada");
            resCust.SetCustomizedString("FilterDialogOkButtonNoFiltersText",
                                        "&Sin Filtros");
            resCust.SetCustomizedString("FilterDialogOkButtonText",
                                        "&Aceptar");
        }

        private void Form1ResizeEnd(object sender, EventArgs e)
        {
            if (Parent != null)
            {
                Parent.Refresh();
            }
        }
    }
}