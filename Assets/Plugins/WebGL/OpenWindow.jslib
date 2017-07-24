var OpenWindowPlugin = {
    openWindow: function(link)
    {
    	var url = Pointer_stringify(link);
        document.onmouseup = function()
        {
        	window.open(url);
        	document.onmouseup = null;
        }
    },
    getCookie: function()
   {
       window.alert(document.cookie);
   }
};

mergeInto(LibraryManager.library, OpenWindowPlugin);
