/*
 * Crée par SharpDevelop.
 * Utilisateur: C357555
 * Date: 05/08/2011
 * Heure: 18:27
 * 
 * Pour changer ce modèle utiliser Outils | Options | Codage | Editer les en-têtes standards.
 */
using System;
using System.IO;
using System.Windows.Forms;
using System.Collections.Generic;

namespace Tools4Libraries
{
	/// <summary>
	/// Description of Manager.
	/// </summary>
	public class GPInterface
	{	
		#region Attributes
		protected List<string> listvisiblecomponents = null;	
		protected string pathFile;
		protected string extention;
        protected bool openned;
        protected Panel _sheet;
        #endregion

        #region Properties
        public Panel Sheet
        {
            get { return _sheet; }
            set { _sheet = value; }
        }
        public string PathFile
        {
            get { return pathFile; }
            set { pathFile = value; }
        }
        public string Extention
		{
			get { return extention; }
			set { extention = value; }
		}
				
		public virtual bool Openned
		{
			get { return openned; }
			set { openned = value; }
		}
		
		public virtual List<string> Listvisiblecomponents
		{
			get { return listvisiblecomponents; }
		}
		
		#endregion
		
		#region Constructor / Destructor
		public GPInterface()
		{
			openned = false;
		}
		
		~GPInterface()
		{
			
		}
		#endregion
		
		#region Methods
        public virtual bool Open(object obj)
        {
            return false;
        }
        public virtual void Print()
		{
			
		}
		public virtual bool Save()
		{
			return false;
		}
		public virtual bool Save(object s)
		{
			return false;
		}
		public virtual void Close()
		{
			
		}
		public virtual void ZoomIn()
		{
			
		}
		public virtual void ZoomOut()
		{
			
		}
		public virtual void Copy()
		{
			
		}
		public virtual void Cut()
		{			
			
		}
		public virtual void Paste()
		{
			
		}
		public virtual void Resize()
		{

        }
        public virtual void Refresh()
        {

        }
        public virtual void RefreshData()
        {
            if (_sheet != null)
            { 
                foreach (Control ctrl in _sheet.Controls)
                {
                    if (ctrl.Name.Equals("CurrentView"))
                    {
                        ((UserControlCustom)ctrl).RefreshData();
                    }
                }
            }
        }
        public virtual void GlobalAction(object sender, EventArgs e)
		{
			
		}
		#endregion
	}
}
