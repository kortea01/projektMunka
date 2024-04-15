import React from 'react';

function HomePage() {
    return (
        <div className="intro">
		<div className="container">
			<div className="row">
				<div className="col">
					<div className="intro_content">
						<div className="intro_subtitle page_subtitle">Minden egyes falata egy családi titok</div>
						<div className="intro_title"><h3>Melyet szeretettel készítünk, hogy Ön is részese legyen a történetünknek!</h3></div>
						<div className="intro_text">
							<p>Üdvözöljük BellaItalia világában, ahol az ételek nemcsak receptek, hanem történetek is. Az éttermünk egy olasz családi vállalkozás, melynek gyökerei egészen Itália szívéig nyúlnak vissza. Nálunk minden fogás egy utazás a hagyományok és az ízek világában. A friss, minőségi alapanyagokat gondosan válogatjuk, hogy az ételeink mindig az autentikus olasz konyha legjavát tükrözzék. Emellett lehetőséget biztosítunk házhozszállításra is, hogy otthonában is élvezhesse az olasz családi vacsora varázsát. Kérjük, lépjen be a mi otthonunkba, és élvezze velünk együtt az igazi olasz ízeket, melyeket családunktól a tiédig hoztunk el. </p>
						</div>
					</div>
					<div className="row">
						<div className="col-xl-4 col-md-6 intro_col">
							<img className="welcomepic" src="./images/wlcm.jpg" alt="dddf" />
						</div>
						<div className="col-xl-4 col-md-6 intro_col">
							<img className='welcomepic' src="./images/welcome2.JPG" alt="img" />
						</div>
					</div>
				</div>	
			</div>
		</div>
	</div>
    );
}


export default HomePage;