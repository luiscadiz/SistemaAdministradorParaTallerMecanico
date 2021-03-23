// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
//PROBANDO HACER UN MODAL
// $(document).ready(function(){
//     $("#btn-create").click(function(){
//         $("#modal-default").modal('show');
//     });
// });

// $(function(){
//     let PlaceHolderElement = $('#PlaceHolderHere'); 
//     $('button[data-toggle="modal"]').click(function(evento){
//         var url = $(this).data('url');
//         $.get(url).done(function(data){
//             PlaceHolderElement.html(data);
//             PlaceHolderElement.find('.modal').modal('show');
//         })
//     })

//     PlaceHolderElement.on('click','[data-save="modal"]', function(event){
        
//         var form = $(this).parents('.modal').find('form');
//         var actionURL = form.attr('action');
//         var sendData = form.serialize();
//         $.post(actionURL,sendData).done(function(data){
//             PlaceHolderElement.find('.modal').modal('hide');
//         })

//     })
// })
$(document).ready( function () {
    $('#table_id').DataTable({
        "ajax": {
            "url": "/Clientes/ObtenerClientes"
        },
        "columns": [
            {"data" : "nombre"},
            {"data" : "apellido"},
            {"data" : "dirección"},
            {"data" : "telefono"},
        ]
    });
});
