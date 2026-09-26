class MiFooter extends HTMLElement {
    connectedCallback() {
        this.innerHTML = `
            <footer>
    <div class="footer-content">
        <div class="footer-item">
            <span class="label">Autor:</span>
            <span class="value">María Daniela Pérez</span>
        </div>
        <div class="footer-divider"></div>
        <div class="footer-item">
            <span class="label">Fecha:</span>
            <span class="value">2026</span>
        </div>
        <div class="footer-divider"></div>
        <div class="footer-item">
            <span class="label">Institución:</span>
            <span class="value">Universidad upateco</span>
        </div>
        <div class="footer-item">
       <span class="label">Fecha:</span>
      <span class="value">&copy; 2026</span>
     </div>
    </div>
</footer>
        `;
    }
}
customElements.define('mi-footer', MiFooter);