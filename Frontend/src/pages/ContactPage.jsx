import React from 'react';


function ContactPage() {
  return (
    <div className="contact">
  
  <h1 className="section-header">Kapcsolat</h1>
  
  <div className="contact-wrapper">
    
    <form id="contact-form" className="form-horizontal" role="form">
       
      <div className="form-group">
            <div className="col-sm-12">
                <input type="text" className="form-control" id="name" placeholder="Név" name="name" value="" required></input>
            </div>
        </div>

      <div className="form-group">
        <div className="col-sm-12">
          <input type="email" className="form-control" id="email" placeholder="E-mail" name="email" value="" required></input>
        </div>
      </div>

      <textarea className="form-control" rows="10" placeholder="Üzenet" name="message" required></textarea>

        <div>
        <button className="btn send-button mt-2" id="submit" type="submit" value="Send">Küldés</button>
        </div>
    </form>
    
      <div className="direct-contact-container">

        <ul className="contact-list">
          <li className="list-item"><i className="fa fa-map-marker fa-2x"><span className="contact-text place">Budapest</span></i></li>
          
          <li className="list-item"><i className="fa fa-phone fa-2x"><span className="contact-text phone">+36 1 666 0000</span></i></li>
          
          <li className="list-item"><i className="fa fa-envelope fa-2x"><span className="contact-text gmail">bellaitalia@nemigazi.com</span></i></li>
          
        </ul>

        <hr />
        <ul className="social-media-list">
          <li><a href="#" target="_blank" className="contact-icon">
            <i className="fa fa-github" aria-hidden="true"></i></a>
          </li>
          <li><a href="#" target="_blank" className="contact-icon">
            <i className="fa fa-codepen" aria-hidden="true"></i></a>
          </li>
          <li><a href="#" target="_blank" className="contact-icon">
            <i className="fa fa-twitter" aria-hidden="true"></i></a>
          </li>
          <li><a href="#" target="_blank" className="contact-icon">
            <i className="fa fa-instagram" aria-hidden="true"></i></a>
          </li>       
        </ul>
        <hr />

        <div className="credits text-secondary text-center mt-2 fs-7">
                Szeretettel a BellaItalia csapata <span className="text-primary">&#9829;</span>
              </div>

        </div>
    </div>
  </div>

  );
}

export default ContactPage;