function mostrarModal() {
    var modal = document.getElementById('myModal');
    $(modal).modal('show');
}
const utils = {
    ajaxPost: (url, model, callback, callbackError) => {
        $.post(url, model)
            .done(callback)
            .fail(callbackError);
    },
};

const create = {
    init: () => {
        create.componentes = {
            cuil: $('#cuil'),
            ApellidoYNombre: $('#ApellidoYNombre'),
            FechaNacimiento: $('#FechaNacimiento'),
            botonAgregar: $('#botonAgregar'),
            UrlPostPersonas: $('#UrlPostPersonas')
        };
        create.componentes.botonAgregar.on('click', create.acciones.botonClick)
    },
    componentes: {
        cuil: undefined,
        ApellidoYNombre: undefined,
        FechaNacimiento: undefined,
        UrlPostPersonas: undefined,
        botonAgregar: undefined
    },
    acciones: {
        botonClick: () => {
            const url = create.componentes.UrlPostPersonas.val();
            const model = {
                nuevo: {
                    cuil: create.componentes.cuil.val(),
                    ApellidoYNombre: create.componentes.ApellidoYNombre.val(),
                    FechaNacimiento: create.componentes.FechaNacimiento.val()
                }

            };
            console.log(model);
            utils.ajaxPost(url, model,
                (data) => {
                    mostrarModal();
                }

            );
        }
    }
}