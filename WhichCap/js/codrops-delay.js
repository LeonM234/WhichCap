var inProgress = false;

Array.prototype.slice.call( document.querySelectorAll( '#la-buttons > button' ) ).forEach( function( el, i ) {
    var anim = el.getAttribute( 'data-anim' ),
        animEl = document.querySelector( '.' + anim );

    el.addEventListener( 'click', function() {
        if( inProgress ) return false;
        inProgress = true;
        classie.add( animEl, 'la-animate' );

        setTimeout( function() {
            classie.remove( animEl, 'la-animate' );
            inProgress = false;
        }, 6000 );
    } );
} );