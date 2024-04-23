import React from 'react';

function AboutUs() {
    return (
        <div className="about">
		<div className="container">
			<div className="row">
				<div className="col">
					<div className="about_content">
						<div className="about_subtitle page_subtitle"><h1 className='abouth1'>Benvenuti al BellaItalia!</h1></div>
						<div className="about_title"></div>
						<div className="about_text">
							<p className='aboutp'>Mi, a Dutti család, örömmel üdvözöljük Önöket olasz családi éttermünkben. Engedjék meg, hogy bemutassam Önöknek családunkat, akik szívvel-lélekkel vezetik ezt az éttermet. 
                                Az konyha chefje: <b>Massimo Dutti</b> az édesapánk, aki hosszú évek óta elkötelezett az igazi olasz ízek és receptek iránt.  
                                Ő az, aki gondoskodik arról, hogy minden egyes ételünk a legmagasabb minőséget képviselje. 
                                Őt követi 4 fia, köztük az első szülőtt: <b>Marcello Dutti</b>, aki szintén szakács és apja mellett tanulta a mesterséget. 
                                Most saját kreatív ételeivel gazdagítja az étterem kínálatát. A másodszülött fia <b>Angelo Dutti</b> a cukrászat művésze. 
                                Ő az édességek varázslója, és minden édességünk mögött az ő kreativitása és tehetsége áll. A középső fia <b>Fabio Dutti</b> a borász a családban. 
                                Ő felel az itallapunkon található kiváló minőségű olasz borokért, amelyek tökéletesen párosulnak ételeinkkel. Végül a legfiatalabb fiú <b>Matteo Dutti</b>, aki a barista szerepét tölti be.
                                Ő gondoskodik arról, hogy minden étel mellé tökéletes kávékülönlegességet kínáljunk vendégeinknek. Az étterem családias légkörét és kifogástalan szolgáltatását a lelkes és elkötelezett személyzetünk teszi teljessé. 
                                Legyen szó a mosolygós pincéreinkről, akik mindig készséggel állnak rendelkezésükre, vagy a konyhai csapatról, akik precízen és odaadással készítik el az ételeket, mindenki közreműködése nélkül nem lenne teljes az élmény. 
                                Büszkék vagyunk rájuk és az általuk nyújtott kiváló szolgáltatásra, ami lehetővé teszi, hogy vendégeink minden alkalommal otthon érezzék magukat nálunk.
                                Összességében, mi, a Dutti család, szeretettel várjuk Önöket, hogy megoszthassuk az ízek és hagyományok varázsát a BellaItalia étteremben. <b>Buon appetito!</b></p>
						</div>
					</div>
					<div className="row">
						<div className="col-xl-4 col-md-6">
							<img className="aboutpic" src="./images/artdarkchef.jpg" alt="dddf" />
						</div>
						<div className="col-xl-4 col-md-6">
							<img className='aboutpic' src="./images/groupchefs.jpg" alt="img" />
						</div>
                        </div>
                        <div className="row">
                        <div className="col-xl-4 col-md-6">
							<img className='aboutpic' src="./images/twochef.jpg" alt="img" />
						</div>
                        <div className="col-xl-4 col-md-6">
							<img className='aboutpic' src="./images/winechef.jpg" alt="img" />
						</div>                       
					</div>
				</div>	
			</div>
		</div>
	</div>
    );
}

export default AboutUs;