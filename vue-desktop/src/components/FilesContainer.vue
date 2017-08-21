<<template>
  <draggable class="file-section" v-model="files" @start="drag=true" @end="drag=false">
    <desktop-button v-for="(file, index) in files" :file="file" :key="index" :dragging="drag"></desktop-button>
  </draggable>
</template>

<script>
import Draggable from 'vuedraggable'
import DesktopButton from './DesktopButton'

export default {
  components: {
    Draggable,
    DesktopButton
  },
  mounted () {
    this.$engine.call({
      ServiceName: 'ZeroRoo.Docker.JsServices.MainAppService',
      Action: 'GetVersion',
      Data: null
    }, res => {
      console.log('ZeroRoo.Docker.JsService.MainAppService', 'GetVersion', res.Data)
    })

    this.$engine.call({
      ServiceName: 'ZeroRoo.Docker.JsServices.DesktopMenuService',
      Action: 'GetDockButtons',
      Data: null
    }, res => {
      console.log('files', res)
      this.files = res.Data
    })
  },
  data () {
    return {
      files: [],
      drag: false
    }
  }
}
</script>

<style scoped>
.file-section{
  background-color: rgb(176, 224, 230);
}
</style>

